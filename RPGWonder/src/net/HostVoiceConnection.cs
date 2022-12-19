using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RPGWonder.src.net
{ 
    internal class HostVoiceConnection
    {
        public static UdpClient udpSender = new UdpClient();
        public static UdpClient second = new UdpClient();
        private readonly static int hostListenPort = 13001;//==clientSendPort
        private readonly static int hostSendPort = 13002;//==clientListenPort
        public static void Listen(string ipAddress) { 
            HostVoiceListener receiver = new HostVoiceListener();
            receiver.Receive(ipAddress, hostListenPort);
        }
        public static void Send(string ipAddress) {
            udpSender.Connect(ipAddress, hostSendPort);
            second.Connect(ipAddress, hostSendPort + 1);
            ClientVoiceSender myVoice = new ClientVoiceSender();
            myVoice.Send(second);
        }
        
    }
}
