using System.Windows.Forms;

namespace RPGWonder
{
    public partial class Host : Form
    {
        private HostTcpConnection connection;
        private string _campaign = "";
        public Host(string campaign)
        {
            InitializeComponent();
            _campaign = campaign;
        }
        private void Host_Load(object sender, System.EventArgs e)
        {
            connection = new HostTcpConnection();
            connection.CreateSession(_campaign);
        }
    }
}
