using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPGWonder.src.dataclass
{
    internal class HostTcpConnection
    {
        private static String json;
        private static List<TcpClient> players = new List<TcpClient>();
        private static List<NetworkStream> streams = new List<NetworkStream>();

        public static void Main()
        {        
        }

        public static void CreateSession() {
            TcpListener server = null;
            try
            {
                Int32 port = 13000;
                //for testing I'll leave loopback
                //IPAddress localAddr = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                server = new TcpListener(localAddr, port);
                server.Start();
                while (true)
                {
                    Console.Write("Waiting for a connection... ");
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected to:  "+ client.ToString());
                    NetworkStream stream = client.GetStream();
                    Thread listenThread = new Thread(new ThreadStart(() => Listen(stream)));
                    listenThread.Start();
                    players.Add(client);
                    streams.Add(stream);
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: {0}", e);
            }
            finally
            {
                server.Stop();
            }
        }

        private static void Listen(NetworkStream stream)
        {
            Byte[] bytes = new Byte[16000];
            int i;
            try
            {
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    json = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("Received: {0}", json);
                    Thread sendThread = new Thread(new ThreadStart(() => ExecuteSending(json)));
                    sendThread.Start();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: {0}", e);
            }
            finally
            {
                stream.Close();
                streams.Remove(stream);
            }
        }
        public void Send(String data)
        {
            //creating a new thread, so that it is non-blocking
            Thread sendThread = new Thread(new ThreadStart(() => ExecuteSending(data)));
            sendThread.Start();
        }
        private static void ExecuteSending(String data)
        {
            foreach (var stream in streams)
            {
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                try
                {
                    stream.Write(msg, 0, msg.Length);
                    Console.WriteLine("Sent: {0} to: {1}", data, stream);
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                    stream.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine("Exception: {0}", e);
                    stream.Close();
                }
            }
        }
    }
}
