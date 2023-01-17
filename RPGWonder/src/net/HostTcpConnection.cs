using RPGWonder.src.net;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace RPGWonder
{
    internal class HostTcpConnection
    {
        private static string recievedString;
        private static List<NetworkStream> streams = new List<NetworkStream>();
        private static List<ClientData> clients = new List<ClientData>();
        private string _campaign = "";
        private readonly static int port = 13000;

        public List<ClientData> Clients { get => clients; set => clients = value; }

        public void CreateSession(string campaign, IPAddress ipAddress)
        {
            _campaign = campaign;
            Thread acceptNewPlayersThread = new Thread(new ThreadStart(() => AcceptNewPlayers(campaign, ipAddress)));
            acceptNewPlayersThread.Start();
        }

        private static void AcceptNewPlayers(string campaign, IPAddress ipAddress)
        {
            TcpListener server = null;
            try
            {
                server = new TcpListener(ipAddress, port);
                server.Start();

                while (true)
                {
                    Debug.Write("Waiting for a connection... ");
                    TcpClient client = server.AcceptTcpClient();

                    NetworkStream stream = client.GetStream();
                    IPAddress ipClient = ((IPEndPoint)client.Client.RemoteEndPoint).Address;//intercept client's ip address
                    Debug.WriteLine("Connected to: "+ ipClient.ToString());

                    Thread listenTcpThread = new Thread(new ThreadStart(() => Listen(stream, campaign)));
                    listenTcpThread.Start();
                    streams.Add(stream);
                }
            }
            catch (SocketException e)
            {
                Debug.WriteLine("SocketException: {0}", e);
            }
            catch (IOException e)
            {
                Debug.WriteLine("Exception: {0}", e);
            }
            finally
            {
                server.Stop();
            }
        }

        private static void Listen(NetworkStream stream, string campaign)
        {
            byte[] bytes = new byte[16000];
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns";
            int i;
            try
            {
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    recievedString = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Debug.WriteLine("Received: {0}", recievedString);
                    if (recievedString == "Connect")
                    {
                        SendToClient("GetSystem", stream);
                    } 
                    else if (recievedString.Contains("System|"))
                    {
                        string system = recievedString.Split('|')[1];
                        if (system != Properties.Settings.Default.System)
                        {
                            SendToClient("WrongSystem|" + Properties.Settings.Default.System, stream);
                        }
                    }
                    else if (recievedString.Contains("Character|"))
                    {
                        string character_tag = recievedString.Split('|')[1];
                        string character_json = recievedString.Split('|')[2];
                        string campaigns_path = campaign.Substring(0, campaign.LastIndexOf('\\'));
                        string campaign_name = campaign.Substring(campaign.LastIndexOf('\\')).Replace("\\", "").Replace(".json", "");
                        string parentDirectory = Path.GetDirectoryName(path + campaign);
                        File.WriteAllText(path + "\\" + campaign_name + "\\characters\\" + character_tag, character_json);
                        Character character = new Character();
                        character.ReadFromJSON(path + "\\" + campaign_name + "\\characters\\" + character_tag);
                        ClientData clientData = new ClientData(stream, character);
                        clients.Add(clientData);
                        Host.instace.Reload();
                        
                        SendToClient("DiscordLink|"+DiscordChannelConnection.GetInviteLink(),stream);
                    }
                    Broadcast(recievedString);
                }
            }
            catch (SocketException e)
            {
                Debug.WriteLine("SocketException: {0}", e);
            }
            catch (IOException e)
            {
                Debug.WriteLine("Exception: {0}", e);
            }
            finally
            {
                stream.Close();
                streams.Remove(stream);
            }
        }
        public static void Broadcast(string data)
        {
            //creating a new thread, so that it is non-blocking
            Thread sendThread = new Thread(new ThreadStart(() => BroadcastThreaded(data)));
            sendThread.Start();
        }
        public static void SendToClient(string data, NetworkStream stream)
        {
            //creating a new thread, so that it is non-blocking
            Thread sendThread = new Thread(new ThreadStart(() => SendToClientThreaded(data, stream)));
            sendThread.Start();
        }
        private static void BroadcastThreaded(string data)
        {
            foreach (NetworkStream stream in streams)
            {
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                try
                {
                    stream.Write(msg, 0, msg.Length);
                    Debug.WriteLine("Sent: {0} to: {1}", data, stream);
                }
                catch (SocketException e)
                {
                    Debug.WriteLine("SocketException: {0}", e);
                    stream.Close();
                }
                catch (IOException e)
                {
                    Debug.WriteLine("Exception: {0}", e);
                    stream.Close();
                }
            }
        }
        private static void SendToClientThreaded(string data, NetworkStream stream)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
            try
            {
                stream.Write(msg, 0, msg.Length);
                Debug.WriteLine("Sent: {0} to: {1}", data, stream);
            }
            catch (SocketException e)
            {
                Debug.WriteLine("SocketException: {0}", e);
                stream.Close();
            }
            catch (IOException e)
            {
                Debug.WriteLine("Exception: {0}", e);
                stream.Close();
            }
        }
    }
}
