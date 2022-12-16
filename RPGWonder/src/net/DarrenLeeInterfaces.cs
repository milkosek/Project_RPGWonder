using NAudio.Wave;
using NSpeex;
using System;
using System.Diagnostics;

namespace RPGWonder.src.net
{
    public interface INetworkChatCodec : IDisposable
    {
        string Name { get; }

        bool IsAvailable { get; }

        int BitsPerSecond { get; }

        WaveFormat RecordFormat { get; }

        byte[] Encode(byte[] data, int offset, int length);

        byte[] Decode(byte[] data, int offset, int length);
    }

    internal class NarrowBandSpeexCodec : SpeexChatCodec
    {
        public NarrowBandSpeexCodec()
          : base(BandMode.Narrow, 8000, "Speex Narrow Band")
        {
        }
    }
    internal class SpeexChatCodec : INetworkChatCodec, IDisposable
    {
        private readonly WaveFormat recordingFormat;
        private readonly SpeexDecoder decoder;
        private readonly SpeexEncoder encoder;
        private readonly WaveBuffer encoderInputBuffer;
        private readonly string description;

        public SpeexChatCodec(BandMode bandMode, int sampleRate, string description)
        {
            this.decoder = new SpeexDecoder(bandMode);
            this.encoder = new SpeexEncoder(bandMode);
            this.recordingFormat = new WaveFormat(sampleRate, 16, 1);
            this.description = description;
            this.encoderInputBuffer = new WaveBuffer(this.recordingFormat.AverageBytesPerSecond);
        }

        public string Name => this.description;

        public int BitsPerSecond => -1;

        public WaveFormat RecordFormat => this.recordingFormat;

        public byte[] Encode(byte[] data, int offset, int length)
        {
            this.FeedSamplesIntoEncoderInputBuffer(data, offset, length);
            int shortBufferCount = this.encoderInputBuffer.ShortBufferCount;
            if (shortBufferCount % this.encoder.FrameSize != 0)
                shortBufferCount -= shortBufferCount % this.encoder.FrameSize;
            byte[] numArray = new byte[length];
            int length1 = this.encoder.Encode(this.encoderInputBuffer.ShortBuffer, 0, shortBufferCount, numArray, 0, length);
            byte[] destinationArray = new byte[length1];
            Array.Copy((Array)numArray, 0, (Array)destinationArray, 0, length1);
            this.ShiftLeftoverSamplesDown(shortBufferCount);
            Debug.WriteLine(string.Format("NSpeex: In {0} bytes, encoded {1} bytes [enc frame size = {2}]", (object)length, (object)length1, (object)this.encoder.FrameSize));
            return destinationArray;
        }

        private void ShiftLeftoverSamplesDown(int samplesEncoded)
        {
            int num = this.encoderInputBuffer.ShortBufferCount - samplesEncoded;
            Array.Copy((Array)this.encoderInputBuffer.ByteBuffer, samplesEncoded * 2, (Array)this.encoderInputBuffer.ByteBuffer, 0, num * 2);
            this.encoderInputBuffer.ShortBufferCount = num;
        }

        private void FeedSamplesIntoEncoderInputBuffer(byte[] data, int offset, int length)
        {
            Array.Copy((Array)data, offset, (Array)this.encoderInputBuffer.ByteBuffer, this.encoderInputBuffer.ByteBufferCount, length);
            this.encoderInputBuffer.ByteBufferCount += length;
        }

        public byte[] Decode(byte[] data, int offset, int length)
        {
            byte[] numArray = new byte[length * 320];
            WaveBuffer waveBuffer = new WaveBuffer(numArray);
            int length1 = this.decoder.Decode(data, offset, length, waveBuffer.ShortBuffer, 0, false) * 2;
            byte[] destinationArray = new byte[length1];
            Array.Copy((Array)numArray, 0, (Array)destinationArray, 0, length1);
            Debug.WriteLine(string.Format("NSpeex: In {0} bytes, decoded {1} bytes [dec frame size = {2}]", (object)length, (object)length1, (object)this.decoder.FrameSize));
            return destinationArray;
        }

        public void Dispose()
        {
        }

        public bool IsAvailable => true;
    }

    internal class UltraWideBandSpeexCodec : SpeexChatCodec
    {
        public UltraWideBandSpeexCodec()
          : base(BandMode.UltraWide, 32000, "Speex Ultra Wide Band (32kHz)")
        {
        }
    }
    internal class WideBandSpeexCodec : SpeexChatCodec
    {
        public WideBandSpeexCodec()
          : base(BandMode.Wide, 16000, "Speex Wide Band (16kHz)")
        {
        }
    }
}