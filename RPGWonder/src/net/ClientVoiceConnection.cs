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
            ClientVoiceListener receiver = new ClientVoiceListener();
            receiver.Receive(ipAddress,clientListenPort);
            //DarrenLee.LiveStream.Audio.ClientVoiceListener receiver = new DarrenLee.LiveStream.Audio.ClientVoiceListener();
            //receiver.Receive(ipAddress, clientListenPort);
        }
        public static void Send(string ipAddress)
        {
            ClientVoiceSender sender = new ClientVoiceSender();
            sender.Send(ipAddress,clientSendPort);
            //DarrenLee.LiveStream.Audio.ClientVoiceSender sender = new DarrenLee.LiveStream.Audio.ClientVoiceSender();
           // sender.Send(ipAddress, clientSendPort);
        }
     }
}
