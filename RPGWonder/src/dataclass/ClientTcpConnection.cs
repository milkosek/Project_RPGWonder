using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPGWonder.src.dataclass
{
    internal class ClientTcpConnection
    {
        private static String json; 

        private static NetworkStream stream;
        public static void Connect(String serverAddr)
        {
            try
            {
                Int32 port = 13000;
                TcpClient client = new TcpClient(serverAddr, port);
                stream = client.GetStream();
                Thread listenThread = new Thread(new ThreadStart(() => Listen()));
                listenThread.Start();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
            }
        }
        public static void Main(string[] args)
        {
            //string host = "127.0.0.1";
            //Connect(host);
        }
        private static void Listen()
        {
            Byte[] bytes = new Byte[16000];
            int i;
            try
            {
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    json = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("Received: {0}", json);
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
            }
        }
        public void Send(String data)
        {
            //creating a new thread, so that it is non-blocking
            Thread sendThread = new Thread(new ThreadStart(() => ExecuteSending(data)));
            sendThread.Start();
        }
        private void ExecuteSending(String data)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
            try{
                stream.Write(msg, 0, msg.Length);
                Console.WriteLine("Sent: {0}", data);

            }
            catch (SocketException e){
                Console.WriteLine("SocketException: {0}", e);
                stream.Close();
            }
            catch (IOException e){
                Console.WriteLine("Exception: {0}", e);
                stream.Close();
            }
        }
    }
}
