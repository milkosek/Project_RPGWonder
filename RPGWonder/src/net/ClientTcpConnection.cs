using RPGWonder.src.net;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace RPGWonder
{
	internal class ClientTcpConnection
	{
		private static string recievedString; 
		private static NetworkStream stream;
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
			string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns";
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
                        string campaign_tag = recievedString.Split('|')[1];
                        string campaign_json = recievedString.Split('|')[2];

                        //string campaigns_path = campaign.Substring(0, campaign.LastIndexOf('\\'));
                        //string campaign_name = campaign.Substring(campaign.LastIndexOf('\\')).Replace("\\", "").Replace(".json", "");
                        //string parentDirectory = Path.GetDirectoryName(path + campaign);

                        Client.Instance.Reload();
                    }
					else if (recievedString.StartsWith("Map|"))
					{
						//string map_tag = recievedString.Split('|')[1];
						//string map_json = recievedString.Split('|')[2];
						//string campaigns_path = campaign.Substring(0, campaign.LastIndexOf('\\'));
						//string campaign_name = campaign.Substring(campaign.LastIndexOf('\\')).Replace("\\", "").Replace(".json", "");
						//string parentDirectory = Path.GetDirectoryName(path + campaign);

						//File.WriteAllText(path + "\\" + campaign_name + "\\characters\\" + map_tag, map_json);

						//Map map = new Map();
						//map.ReadFromJSON(path + "\\" + campaign_name + "\\characters\\" + map_tag);

						//Client.Instance.Reload();
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
				//stream.Close();
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
		public void ValidateSystem()
		{
			Send("Connect");
		}
		public void SendMap(string map, string map_json)
		{
			Send("Character|" + map + "|" + map_json);
		}

		public void SendCharacter(string character, string character_json)
		{
			Send("Character|" + character + "|" + character_json);
		}
	}
}
