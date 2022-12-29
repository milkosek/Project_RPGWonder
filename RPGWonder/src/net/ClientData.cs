using System.Net.Sockets;

namespace RPGWonder
{
    internal class ClientData
    {
        private NetworkStream _stream;
        private Character _character;
        public ClientData(NetworkStream stream, Character character)
        {
            _stream = stream;
            _character = character;
        }
        public NetworkStream Stream { get => _stream; set => _stream = value; }
        public Character Character { get => _character; set => _character = value; }
    }
}
