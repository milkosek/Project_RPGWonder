using System.Windows.Forms;

namespace RPGWonder
{
    public partial class Client : Form
    {
        private ClientTcpConnection connection;
        public Client()
        {
            InitializeComponent();
        }
        private void Client_Load(object sender, System.EventArgs e)
        {
            //MainMenu.instance.Hide();
            connection = new ClientTcpConnection();
            connection.Connect("127.0.0.1");
            connection.Send("hi");
        }
    }
}
