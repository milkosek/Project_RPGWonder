using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPGWonder.src.net
{ 
    internal class HostVoiceConnection
    {
        public static UdpClient udpSender = new UdpClient();
        public static UdpClient second = new UdpClient();
        private readonly static int hostListenPort = 13001;//==clientSendPort
        private readonly static int hostSendPort = 13003;//==clientListenPort
        public static void Listen(string ipAddress) {
            HostVoiceListener receiver = new HostVoiceListener();
            HostVoiceListener x = new HostVoiceListener();
            Thread SendVoiceThread = new Thread(new ThreadStart(() => receiver.Receive(ipAddress, hostListenPort)));
            SendVoiceThread.Start();
            x.Receive(ipAddress, hostListenPort + 1);
        }
        public static void Send(string ipAddress) {
            UdpClient x = new UdpClient();
            x.Connect(ipAddress, hostSendPort);
            ClientVoiceSender sender = new ClientVoiceSender();
            Thread SendVoiceThread = new Thread(new ThreadStart(() => sender.Send(x)));
            SendVoiceThread.Start();
        }
        
    }
}
