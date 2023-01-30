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
            NetworkStream stream = null;

            try
            {
                server = new TcpListener(ipAddress, port);
                server.Start();

                while (true)
                {
                    Debug.Write("Waiting for a connection... ");
                    TcpClient client = server.AcceptTcpClient();

                    stream = client.GetStream();
                    //intercept client's ip address
                    IPAddress ipClient = ((IPEndPoint)client.Client.RemoteEndPoint).Address;
                    Debug.WriteLine("Connected to: "+ ipClient.ToString());

                    Thread listenTcpThread = new Thread(new ThreadStart(() => Listen(stream, campaign)));
                    listenTcpThread.Start();
                    streams.Add(stream);
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
                server.Stop();
            }
        }

        private static void Listen(NetworkStream stream, string campaign)
        {
            byte[] bytes = new byte[16000];
            string path = Common.Instance.CampaignsPath;
            int i;
            string campaign_name = campaign.Substring(campaign.LastIndexOf('\\')).Replace("\\", "").Replace(".json", "");

            try
            {
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    recievedString = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    //Debug.WriteLine("Received: {0}", recievedString);
                    if (recievedString == "Connect")
                    {
                        SendToClient("GetSystem", stream);
                    } 
                    else if (recievedString.Contains("System|"))
                    {
                        string system = recievedString.Split('|')[1];
                        if (system != Properties.Settings.Default.System){
                            SendToClient("WrongSystem|" + Properties.Settings.Default.System, stream);
                        }
                    }
                    else if (recievedString.Contains("Character|"))
                    {
                        SendToClient("DiscordLink|" + DiscordChannelConnection.GetInviteLink(), stream);

                        string character_tag = recievedString.Split('|')[1];
                        string character_json = recievedString.Split('|')[2];
                        string parentDirectory = Path.GetDirectoryName(path + campaign);

                        File.WriteAllText(path + "\\" + campaign_name + "\\characters\\" + character_tag, character_json);
                        
                        Character character = new Character();
                        character.ReadFromJSON(path + "\\" + campaign_name + "\\characters\\" + character_tag);
                        
                        ClientData clientData = new ClientData(stream, character);
                        clients.Add(clientData);

                        Host.Instance.NewPLayerConnected(stream);
                    }
                    else if (recievedString.StartsWith("MapUpdate|"))
                    {
                        string map_tag = recievedString.Split('|')[1];
                        string map_json = recievedString.Split('|')[2];

                        File.WriteAllText(path + "\\" + campaign_name + "\\maps\\" + map_tag, map_json);

                        Map map = new Map();
                        map.ReadFromJSON(path + "\\" + campaign_name + "\\maps\\" + map_tag);

                        Host.Instance.Invoke(Host.Instance.reloadDelegate);

                        BroadcastMRE(recievedString);

                        Host.Instance.nextPLayer();
                    }

                    if (recievedString.StartsWith("Map|"))
                    {
                        Host.Instance.nextPLayer();
                    }

                    stream.Flush();
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
                streams.Remove(stream);

                int index = clients.FindIndex(f => f.Stream == stream);
                if (index != -1)
                {
                    clients.RemoveAt(index);
                    //todo broadcast when someone disconnects
                    //Host.Instance.NewPLayerConnected();
                }
            }
        }
        public static void Broadcast(string data)
        {
            //creating a new thread, so that it is non-blocking
            Thread sendThread = new Thread(new ThreadStart(() => BroadcastThreaded(data)));
            sendThread.Start();
        }
        public static void BroadcastMRE(string data)
        {
            ManualResetEvent mre = new ManualResetEvent(false);

            Thread sendThread = new Thread(new ThreadStart(() =>
            {
                BroadcastThreaded(data);
                mre.Set();
            }));

            sendThread.Start();
            mre.WaitOne();
        }

        public static void SendMRE(string data, NetworkStream stream)
        {
            ManualResetEvent mre = new ManualResetEvent(false);

            Thread sendThread = new Thread(new ThreadStart(() =>
            {
                SendToClientThreaded(data, stream);
                mre.Set();
            }));

            sendThread.Start();
            mre.WaitOne();
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
                    //Debug.WriteLine("Sent: {0} to: {1}", data, stream);
                }
                catch (SocketException e)
                {
                    //Debug.WriteLine("SocketException: {0}", e);
                    stream.Close();
                }
                catch (IOException e)
                {
                    //Debug.WriteLine("Exception: {0}", e);
                    stream.Close();
                }
                finally
                {
                    stream.Flush();
                }
            }
        }
        private static void SendToClientThreaded(string data, NetworkStream stream)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
            try
            {
                stream.Write(msg, 0, msg.Length);
                //Debug.WriteLine("Sent: {0} to: {1}", data, stream);
            }
            catch (SocketException e)
            {
                //Debug.WriteLine("SocketException: {0}", e);
                stream.Close();
            }
            catch (IOException e)
            {
                //Debug.WriteLine("Exception: {0}", e);
                stream.Close();
            }
            finally 
            {
                stream.Flush();
            }
        }

        public static void SendCampaign(string campaign, string campaign_json, string map, string map_json, NetworkStream stream)
        {
            //Debug.WriteLine("Broadcasting campaign");
            SendMRE("Campaign|" + campaign + "|" + campaign_json, stream);

            SendMRE("MapChange|" + map + "|" + map_json, stream);
        }

        public static void BroadcastMap(string map, string map_json)
        {
            //Debug.WriteLine("Broadcasting map");
            Broadcast("MapChange|" + map + "|" + map_json);
        }

        public static void BroadcastMapUpdate(string map, string map_json)
        {
            //Debug.WriteLine("Broadcasting map");
            Broadcast("MapUpdate|" + map + "|" + map_json);
        }

        public static void BroadcastCharacter(string character, string character_json)
        {
            //Debug.WriteLine("Broadcasting character");
            Broadcast("Character|" + character + "|" + character_json);
        }

        public static void YourTurn(int playerNum)
        {
            //Debug.WriteLine("Broadcasting character");
            SendToClient("Turn|", streams[playerNum]);
        }
        public static void BroadcastAsset(string assetPath)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(assetPath);
            string base64ImageRepresentation = System.Convert.ToBase64String(imageArray);
            Broadcast("Asset|" + System.IO.Path.GetFileName(assetPath) + "|" + base64ImageRepresentation);
        }
    }
}
