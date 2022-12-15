using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using RPGWonder.src.net;
using System.Threading;

namespace RPGWonder
{
    public partial class Host : Form
    {
        private HostTcpConnection connection;
        private string _campaign = "";
        private IPAddress ipAddress;
        public Host(string campaign)
        {
            InitializeComponent();
            _campaign = campaign;
            ipAddress = IPAdd.GetMyIPAddress();
        }
        private void Host_Load(object sender, System.EventArgs e)
        {
            Thread listenVoiceThread = new Thread(new ThreadStart(() => HostVoiceConnection.Listen(ipAddress.ToString())));
            listenVoiceThread.Start();  // creating udp socket for voice communication

            connection = new HostTcpConnection();
            connection.CreateSession(_campaign, ipAddress);            
        }
    }
}
