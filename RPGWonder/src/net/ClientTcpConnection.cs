using Discord;
using RPGWonder.src.net;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Web.UI;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace RPGWonder
{
	internal class ClientTcpConnection
	{
		private static string receivedString; 
		private static NetworkStream stream;

		private Campaign _campaign;

		public void Connect(string serverAddr)
		{
			try
			{
				int port = 13000;
				//Debug.WriteLine(serverAddr);
				TcpClient client = new TcpClient(serverAddr, port);
				stream = client.GetStream();
				Thread listenThread = new Thread(new ThreadStart(() => Listen()));
				listenThread.Start();
			}
			catch (ArgumentNullException e)
			{
				//Debug.WriteLine("ArgumentNullException: {0}", e);
			}
			catch (SocketException e)
			{
				//Debug.WriteLine("SocketException: {0}", e);
			}
			catch (Exception e)
			{
				//Debug.WriteLine("Exception: {0}", e);
			}
		}
		private static void Listen()
		{
			byte[] bytes = new byte[16000000];
			string path = Common.Instance.ClientCampaignsPath;
			int i;

			try
			{
				while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
				{
					receivedString = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
					
					//Debug.WriteLine("Received: {0}", receivedString);
					
					if (receivedString == "GetSystem")
					{
						Send("System|" + Properties.Settings.Default.System);
					}
					else if (receivedString.StartsWith("Campaign|"))
					{
						if (!Directory.Exists(path))
						{
                            Directory.CreateDirectory(path);
                        }

                        string campaign_tag = receivedString.Split('|')[1];
                        string campaign_json = receivedString.Split('|')[2];

                        File.WriteAllText(path + "\\" + campaign_tag, campaign_json);

                        Client.Instance.LoadCampaign(campaign_tag);
                    }
					else if (receivedString.StartsWith("MapChange|"))
					{
						if (!Directory.Exists(path + "\\maps"))
						{
							Directory.CreateDirectory(path + "\\maps");
						}

						string map_tag = receivedString.Split('|')[1];
						string map_json = receivedString.Split('|')[2];

						File.WriteAllText(path + "\\maps\\" + map_tag, map_json);

						Map map = new Map();
						map.ReadFromJSON(path + "\\maps\\" + map_tag);

						Client.Instance.Invoke(Client.Instance.reloadDelegateLoadMap, (int)map.Id);
					}
					else if (receivedString.StartsWith("MapUpdate|"))
					{
						string map_tag = receivedString.Split('|')[1];
						string map_json = receivedString.Split('|')[2];

						File.WriteAllText(path + "\\maps\\" + map_tag, map_json);

						Map map = new Map();
						map.ReadFromJSON(path + "\\maps\\" + map_tag);

						Client.Instance.Invoke(Client.Instance.reloadDelegateReloadEntities, 0);
					}
					else if (receivedString.Contains("Turn|"))
                    {
                        Client.Instance.YourTurn = true;
						Client.Instance.Invoke(Client.Instance.reloadDelegateTurn, 0);
					}
					else if (receivedString.Contains("WrongSystem:"))
					{
						string system = receivedString.Split('|')[1];
						string message = "Game system mismatch.\nMake sure your game system is set to " + system;
						MessageBox.Show(message);
						Client.Instance.Close();
					}
					else if (receivedString.StartsWith("DiscordLink|")){
						string link = receivedString.Substring("DiscordLink|".Length);

						Thread openLinkThread = new Thread(new ThreadStart(() => DiscordChannelConnection.OpenInviteLink(link)));
						openLinkThread.Start();
					}
					else if (receivedString.StartsWith("Asset|"))
                    {
						string fileName = receivedString.Split('|')[1];
						string filePath = Common.Instance.ClientCampaignsPath + "\\assets\\" + fileName;
						string image = receivedString.Substring(("Asset|" + fileName + "|").Length);
						System.Drawing.Image asset = System.Drawing.Image.FromStream(new MemoryStream(Convert.FromBase64String(image)));
						Directory.CreateDirectory(Common.Instance.ClientCampaignsPath + "\\assets\\");
						if(System.IO.File.Exists(filePath))
                        {
							System.IO.File.Delete(filePath);
                        }
						asset.Save(filePath);
						Client.Instance.ChangeAsset(filePath);
                    }
				}
			}
			catch (SocketException e)
			{
				//Debug.WriteLine("SocketException: {0}", e);
			}
			catch (IOException e)
			{
				//Debug.WriteLine("Exception: {0}", e);
			}
			finally
			{
				stream.Close();
            }
		}
		public static void Send(string data)
		{
			//creating a new thread, so that it is non-blocking
			Thread sendThread = new Thread(new ThreadStart(() => ExecuteSending(data)));
			sendThread.Start();
		}
		private static void ExecuteSending(string data)
		{
			byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
			try{
				stream.Write(msg, 0, msg.Length);
				//Debug.WriteLine("Sent: {0}", data);
			}
			catch (SocketException e){
				//Debug.WriteLine("SocketException: {0}", e);
				stream.Close();
			}
			catch (IOException e){
				//Debug.WriteLine("Exception: {0}", e);
				stream.Close();
			}
		}

        public static void ValidateSystem()
		{
			Send("Connect");
		}

		public static void SendMap(string map, string map_json)
		{
			Send("MapUpdate|" + map + "|" + map_json);
		}

        public static void SendCharacter(string character, string character_json)
		{
            Send("Character|" + character + "|" + character_json);
        }

		public static void CloseStream()
        {
			stream.Close();
		}
	}
}
