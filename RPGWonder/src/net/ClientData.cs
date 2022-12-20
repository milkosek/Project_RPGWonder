using System.Net.Sockets;

namespace RPGWonder
{
    internal class ClientData
    {
        private NetworkStream stream;
        private string characterName;
        public ClientData(NetworkStream stream, string characterName)
        {
            Stream = stream;
            CharacterName = characterName;
        }

        public NetworkStream Stream { get => stream; set => stream = value; }
        public string CharacterName { get => characterName; set => characterName = value; }
    }
}
