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
    //TODO: udp closing after losing connection
    internal class ClientVoiceConnection
    {

        private readonly static int clientListenPort = 13002;//==hostSendPort
        private readonly static int clientSendPort = 13001;//==hostListenPort
        public static void Listen(string ipAddress)
        {
            VoiceReceiver receiver = new VoiceReceiver();
            receiver.Receive(ipAddress,clientListenPort);
            //DarrenLee.LiveStream.Audio.VoiceReceiver receiver = new DarrenLee.LiveStream.Audio.VoiceReceiver();
            //receiver.Receive(ipAddress, clientListenPort);
        }
        public static void Send(string ipAddress)
        {
            VoiceSender sender = new VoiceSender();
            sender.Send(ipAddress,clientSendPort);
            //DarrenLee.LiveStream.Audio.VoiceSender sender = new DarrenLee.LiveStream.Audio.VoiceSender();
           // sender.Send(ipAddress, clientSendPort);
        }
     }
}
