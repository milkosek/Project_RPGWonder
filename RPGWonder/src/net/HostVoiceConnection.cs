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
            DarrenLee.LiveStream.Audio.Receiver receiver = new DarrenLee.LiveStream.Audio.Receiver();
            receiver.Receive(ipAddress, hostListenPort);
        }
        public static void Send(string ipAddress) {
            DarrenLee.LiveStream.Audio.Sender sender = new DarrenLee.LiveStream.Audio.Sender();
            sender.Send(ipAddress, hostSendPort);
        }
        
    }
}
