using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class Client : Form
    {
        private ClientTcpConnection connection;
        private readonly string _character = "";
        public static Client instance;
        public Client(string character)
        {
            InitializeComponent();
            instance = this;
            _character = character;
        }
        private void Client_Load(object sender, System.EventArgs e)
        {
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\characters";
            //MainMenu.instance.Hide();
            connection = new ClientTcpConnection();
            connection.Connect("127.0.0.1");
            connection.ValidateSystem();
            connection.SendCharacter(File.ReadAllText(path + _character), _character);
        }
    }
}
