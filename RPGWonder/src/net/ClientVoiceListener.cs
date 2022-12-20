using NAudio.Wave;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace RPGWonder.src.net
{
    public class ClientVoiceListener
    {
        private UdpClient listenerAudio;
        private IPEndPoint myEndPoint;
        private IWavePlayer waveOut;
        private BufferedWaveProvider waveProvider;
        private INetworkChatCodec selectedCodec;

        public ClientVoiceListener() => this.selectedCodec = (INetworkChatCodec)new NarrowBandSpeexCodec();

        public bool Receive(string receiver_ip, int port)
        {
            try
            {
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
                    this.waveProvider.AddSamples(buffer, 0, buffer.Length);
                }
                catch (SocketException ex)
                {
                }
            }
        }
    }
}
