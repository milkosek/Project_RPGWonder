using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System;

namespace RPGWonder
{
    /// <summary>
    /// Class representing a from with game window as seen by the Host
    /// </summary>
    public partial class Host : DefaultForm
    {
        private HostTcpConnection _connection;
        public static Host instace;
        private string _campaign = "";
        private IPAddress _ipAddress;

        /// <summary>
        /// Public contructor of <see cref="Host"/> class.
        /// </summary>
        /// <param name="campaign">The capaign that is hosted.</param>
        public Host(string campaign)
        {
            InitializeComponent();
            SetMotif();
            instace = this;
            _campaign = campaign;
            Debug.WriteLine(_campaign);
            try
            {
                _ipAddress = IPAdd.GetMyIPAddress();
                //ipAddress = IPAddress.Parse("127.0.0.1");
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Error getting ip: " + exception);
                Close();
            }
            finally
            {
                Log.Instance.gameLog.Debug("Got ip adress: " + _ipAddress);
            }

        }
        private void Host_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Log.Instance.gameLog.Debug("Attempting to establish connection...");
            try
            {
                _connection = new HostTcpConnection();
                _connection.CreateSession(_campaign, _ipAddress);
                Log.Instance.gameLog.Debug("Estabilish connection success.");
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Establishing connection failed with error: " + exception.Message);
            }
        }

        /// <summary>
        /// Method for reloading the game state.
        /// </summary>
        public void Reload()
        {
            foreach(ClientData client in _connection.Clients)
            {
                Character character = client.Character;
                charlabel.Text = charlabel.Text + character.Name;
            }
        }
    }
}
