
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace RPGWonder.src.net
{
    public class HostVoiceSender
    {
        public static void Send(UdpClient udpSender, byte[] data)
        {
            try
            {
                udpSender.Send(data, data.Length);
            }
            catch (SocketException ex)
            {
            }
        }
    }
}
