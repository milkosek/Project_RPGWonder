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
    internal class ClientVoiceConnection
    {

        private readonly static int clientListenPort = 13002;//==hostSendPort
        private readonly static int clientSendPort = 13001;//==hostListenPort
        public static void Listen(string ipAddress)
        {
            DarrenLee.LiveStream.Audio.Receiver receiver = new DarrenLee.LiveStream.Audio.Receiver();
            receiver.Receive(ipAddress, clientListenPort);
        }
        public static void Send(string ipAddress)
        {
            DarrenLee.LiveStream.Audio.Sender sender = new DarrenLee.LiveStream.Audio.Sender();
            sender.Send(ipAddress, clientSendPort);
        }
     }
}
