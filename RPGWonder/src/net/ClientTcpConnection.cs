using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace RPGWonder
{
    internal class ClientTcpConnection
    {
        private static String json; 

        private static NetworkStream stream;
        public void Connect(String serverAddr)
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
                Debug.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Debug.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: {0}", e);
            }
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
                    Debug.WriteLine("Received: {0}", json);
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
                Debug.WriteLine("Sent: {0}", data);

            }
            catch (SocketException e){
                Debug.WriteLine("SocketException: {0}", e);
                stream.Close();
            }
            catch (IOException e){
                Debug.WriteLine("Exception: {0}", e);
                stream.Close();
            }
        }
    }
}
