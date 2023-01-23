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

namespace RPGWonder
{
	internal class ClientTcpConnection
	{
		private static string recievedString; 
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
			byte[] bytes = new byte[16000];
			string path = Common.Instance.ClientCampaignsPath;
			int i;

			try
			{
				while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
				{
					recievedString = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
					
					//Debug.WriteLine("Received: {0}", recievedString);
					
					if (recievedString == "GetSystem")
					{
						Send("System|" + Properties.Settings.Default.System);
					}
					else if (recievedString.StartsWith("Campaign|"))
					{
						if (!Directory.Exists(path))
						{
                            Directory.CreateDirectory(path);
                        }

                        string campaign_tag = recievedString.Split('|')[1];
                        string campaign_json = recievedString.Split('|')[2];

                        File.WriteAllText(path + "\\" + campaign_tag, campaign_json);

                        Client.Instance.LoadCampaign(campaign_tag);
                    }
					else if (recievedString.StartsWith("MapChange|"))
					{
						if (!Directory.Exists(path + "\\maps"))
						{
							Directory.CreateDirectory(path + "\\maps");
						}

						string map_tag = recievedString.Split('|')[1];
						string map_json = recievedString.Split('|')[2];

						File.WriteAllText(path + "\\maps\\" + map_tag, map_json);

						Map map = new Map();
						map.ReadFromJSON(path + "\\maps\\" + map_tag);

						Client.Instance.Invoke(Client.Instance.reloadDelegate, (int)map.Id);
					}
					else if (recievedString.StartsWith("MapUpdate|"))
					{
						string map_tag = recievedString.Split('|')[1];
						string map_json = recievedString.Split('|')[2];

						File.WriteAllText(path + "\\maps\\" + map_tag, map_json);

						Map map = new Map();
						map.ReadFromJSON(path + "\\maps\\" + map_tag);

						Client.Instance.Invoke(Client.Instance.reloadDelegate2, 0);
					}
					else if (recievedString.Contains("Turn|"))
                    {
                        Client.Instance.YourTurn = true;
						Client.Instance.Reload();
                    }
                    else if (recievedString.Contains("WrongSystem:"))
					{
						string system = recievedString.Split('|')[1];
						string message = "Game system mismatch.\nMake sure your game system is set to " + system;
						MessageBox.Show(message);
						Client.Instance.Close();
					}
					else if (recievedString.StartsWith("DiscordLink|")){
						string link = recievedString.Substring("DiscordLink|".Length);

						Thread openLinkThread = new Thread(new ThreadStart(() => DiscordChannelConnection.OpenInviteLink(link)));
						openLinkThread.Start();
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
