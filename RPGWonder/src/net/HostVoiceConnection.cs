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
        private readonly static int hostListenPort = 13001;//==clientSendPort
        private readonly static int hostSendPort = 13002;//==clientListenPort
        public static void Listen(string ipAddress) { 
            ClientVoiceListener receiver = new ClientVoiceListener();
            receiver.Receive(ipAddress, hostListenPort);
        }
        public static void Send(string ipAddress) {
            ClientVoiceSender sender = new ClientVoiceSender();
            sender.Send(ipAddress, hostSendPort);
        }
        
    }
}
