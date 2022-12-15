using RPGWonder.src.net;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class Client : Form
    {
        private ClientTcpConnection connection;
        private readonly string _character = "";
        public static Client instance;
        private static string localIpAddress;
        private static string hostIpAddress;
        public Client(string character, string ipAddr)
        {
            InitializeComponent();
            instance = this;
            _character = character;
            hostIpAddress = ipAddr;
            localIpAddress = IPAdd.GetMyIPAddress().ToString();
        }
        private void Client_Load(object sender, System.EventArgs e)
        {
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\characters";
            //MainMenu.instance.Hide();
            connection = new ClientTcpConnection();
            connection.Connect(hostIpAddress);//hostIp

            ClientVoiceConnection.Listen(localIpAddress);
            ClientVoiceConnection.Send(hostIpAddress);

            connection.ValidateSystem();
            connection.SendCharacter(File.ReadAllText(path + _character), _character);
        }
    }
}
