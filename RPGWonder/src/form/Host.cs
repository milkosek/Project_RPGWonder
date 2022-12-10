using System.Diagnostics;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class Host : Form
    {
        private HostTcpConnection connection;
        public Host()
        {
            InitializeComponent();
        }
        private void Host_Load(object sender, System.EventArgs e)
        {
            Debug.WriteLine("aaaa");
            connection = new HostTcpConnection();
            connection.CreateSession();
        }
    }
}
