using System.IO;

namespace RPGWonder
{
    public partial class Client : Game
    {
        //TODO: Error handling wpisywanego adresu ip

        private ClientTcpConnection connection;
        private readonly string _character = "";
        public static Client instance;
        private static string hostIpAddress;
        public Client(string character, string ipAddr) : base()
        {
            instance = this;
            SetMotif();
            _character = character;
            hostIpAddress = ipAddr;
        }

        private void Client_Load(object sender, System.EventArgs e)
        {
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\characters";
            //MainMenu.instance.Hide();
            connection = new ClientTcpConnection();
            connection.Connect(hostIpAddress);//hostIp

            connection.ValidateSystem();
            connection.SendCharacter(File.ReadAllText(path + _character), _character);
        }
    }
}
