using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace RPGWonder
{
    public partial class Host : DefaultForm
    {
        private HostTcpConnection connection;
        public static Host instace;
        private string _campaign = "";
        private IPAddress ipAddress;
        public Host(string campaign)
        {
            InitializeComponent();
            SetMotif();
            instace = this;
            _campaign = campaign;
            Debug.WriteLine(_campaign);
            //ipAddress = IPAdd.GetMyIPAddress();
            ipAddress = IPAddress.Parse("127.0.0.1");
        }
        private void Host_Load(object sender, System.EventArgs e)
        {
            connection = new HostTcpConnection();
            connection.CreateSession(_campaign, ipAddress);
            CheckForIllegalCrossThreadCalls = false;
        }
        public void Reload()
        {
            foreach(ClientData client in connection.Clients)
            {
                Character character = client.Character;
                charlabel.Text = charlabel.Text + character.Name;
            }
        }
    }
}
