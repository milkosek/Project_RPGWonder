using NAudio.Wave;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace RPGWonder.src.net
{
    public class HostVoiceListener
    {
        private int portd;
        private string host;
        private UdpClient listenerAudio;
        private IPEndPoint myEndPoint;
        private IWavePlayer waveOut;
        private BufferedWaveProvider waveProvider;
        private INetworkChatCodec selectedCodec;

        public HostVoiceListener() => this.selectedCodec = (INetworkChatCodec)new NarrowBandSpeexCodec();

        public bool Receive(string receiver_ip, int port)
        {
            try
            {
                host = receiver_ip;
                portd = port;
                this.myEndPoint = new IPEndPoint(IPAddress.Parse(receiver_ip), port);
                this.listenerAudio = new UdpClient();
                this.listenerAudio.Client.Bind((EndPoint)this.myEndPoint);
                this.waveOut = (IWavePlayer)new WaveOut();
                this.waveProvider = new BufferedWaveProvider(this.selectedCodec.RecordFormat);
                this.waveOut.Init((IWaveProvider)this.waveProvider);
                this.waveOut.Play();
                Task.Factory.StartNew((Action)(() => this.ListenerA()));
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void ListenerA()
        {
            while (true)
            {
                try
                {
                    byte[] data = this.listenerAudio.Receive(ref this.myEndPoint);


                    byte[] buffer = this.selectedCodec.Decode(data, 0, data.Length);
                    Thread ListenVoiceThread = new Thread(() => this.waveProvider.AddSamples(buffer, 0, buffer.Length));
                    ListenVoiceThread.Start();

                    UdpClient a = new UdpClient();
                    a.Connect(host,portd+1);
                    Thread SendVoiceThread = new Thread(new ThreadStart(() => HostVoiceSender.Send(a,data)));
                    SendVoiceThread.Start();
                }
                catch (SocketException ex)
                {
                }
            }
        }
    }
}
