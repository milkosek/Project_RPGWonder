
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace RPGWonder.src.net
{
    public class Sender
    {
        private WaveInEvent waveIn;
        private UdpClient udpSender;
        private INetworkChatCodec selectedCodec;
        private volatile bool connected;
        private IPAddress serverip;
        private int serveraudioPort;
        private List<string> deviceList;

        public Sender()
        {
            this.deviceList = new List<string>();
            this.PopulateInputDevicesList();
            this.selectedCodec = new UltraWideBandSpeexCodec();
        }

        private void PopulateInputDevicesList()
        {
            for (int devNumber = 0; devNumber < WaveIn.DeviceCount; ++devNumber)
                this.deviceList.Add(WaveIn.GetCapabilities(devNumber).ProductName);
        }

        public bool Send(string receiver_ip, int port)
        {
            try
            {
                this.serverip = IPAddress.Parse(receiver_ip);
                this.serveraudioPort = port;
                Task.Factory.StartNew((Action)(() => this.ListenAudio()));
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void ListenAudio()
        {
            this.udpSender = new UdpClient();
            this.udpSender.Connect(this.serverip, this.serveraudioPort);
            this.waveIn = new WaveInEvent();
            this.waveIn.BufferMilliseconds = 50;
            this.waveIn.DeviceNumber = 0;
            this.waveIn.WaveFormat = this.selectedCodec.RecordFormat;
            this.waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(this.waveIn_DataAvailable);
            this.waveIn.StartRecording();
            this.connected = true;
        }

        public void Disconnect()
        {
            if (!this.connected)
                return;
            this.connected = false;
            this.waveIn.DataAvailable -= new EventHandler<WaveInEventArgs>(this.waveIn_DataAvailable);
            this.waveIn.StopRecording();
            this.udpSender.Close();
            this.waveIn.Dispose();
            this.selectedCodec.Dispose();
        }

        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            byte[] dgram = this.selectedCodec.Encode(e.Buffer, 0, e.BytesRecorded);
            this.udpSender.Send(dgram, dgram.Length);
        }
    }
}
