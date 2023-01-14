using System.Diagnostics;
using System.IO;

namespace RPGWonder
{
    public partial class Client : DefaultForm
    {
        private ClientTcpConnection connection;
        private readonly string _character = "";
        private static string hostIpAddress;
        public static Client Instance;
        public Client(string character, string ipAddr)
        {
            InitializeComponent();
            Instance = this;
            SetMotif();
            _character = character;
            hostIpAddress = ipAddr;
        }
        private void Client_Load(object sender, System.EventArgs e)
        {
            //MainMenu.instance.Hide();
            connection = new ClientTcpConnection();
            Debug.WriteLine("aaa");
            connection.Connect(hostIpAddress);//hostIp
            Debug.WriteLine("aaa");
            connection.ValidateSystem();
            Debug.WriteLine(File.ReadAllText(_character));
            Debug.WriteLine(Path.GetFileName(_character));
            connection.SendCharacter(File.ReadAllText(_character), Path.GetFileName(_character));
        }
    }
}
