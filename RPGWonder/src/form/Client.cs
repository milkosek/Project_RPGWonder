using System;
using System.Diagnostics;
using System.IO;

namespace RPGWonder
{
    public partial class Client : DefaultForm
    {
        private ClientTcpConnection _connection;
        private readonly string _character;
        private static string _hostIpAddress;
        public static Client Instance;

        public Client(string character, string ipAddr)
        {
            InitializeComponent();
            Instance = this;
            SetMotif();
            _character = character;
            _hostIpAddress = ipAddr;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            //MainMenu._instance.Hide();
            Log.Instance.gameLog.Debug("Attempting to establish connection...");
            try
            {
                _connection = new ClientTcpConnection();
                _connection.Connect(_hostIpAddress);
                _connection.ValidateSystem();
                _connection.SendCharacter(File.ReadAllText(_character), Path.GetFileName(_character));
                Log.Instance.gameLog.Debug("Estabilish connection success.");
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Establishing connection failed with error: " + exception.Message);
            }
        }
    }
}
