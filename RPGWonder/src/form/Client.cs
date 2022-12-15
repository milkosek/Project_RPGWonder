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
        private static string hostIpAddress = "127.0.0.1";
        public Client(string character)
        {
            InitializeComponent();
            instance = this;
            _character = character;
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
        public void SetHostIpAddress(string ipAddress) { //Kuba, ogarnij, gdzie wywołać
            hostIpAddress = ipAddress;
        }
    }
}
