using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// Class representing a form for joining an existing game session.
    /// </summary>
    public partial class JoinSession : DefaultForm
    {
        private static JoinSession _instance = null;
        private string _character;
        private string _ipAddr;
        public static JoinSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JoinSession();
                }
                return _instance;
            }
        }

        private JoinSession()
        {
            InitializeComponent();
            SetMotif();
        }

        private void JoinSession_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            string[] filePaths = Directory.GetFiles(Common.Instance.CharactersPath, "*.json");
            foreach (string filePath in filePaths)
            {
                try
                {
                    JObject character = JObject.Parse(File.ReadAllText(filePath));
                    ComboBoxObject comboBoxObject = new ComboBoxObject(filePath, (string)character["Name"]);
                    charactersComboBox.Items.Add(comboBoxObject);
                }
                catch (Exception exception)
                {
                    Log.Instance.errorLog.Error("Cannot load " + filePath + ". Error: " + exception.Message);
                    continue;
                }
            }
        }

        private void JoinGameButton_Click(object sender, EventArgs e)
        {
            if(_character != null)
            {
                _ipAddr = ipAddrInput.Text;
                Client gameWindow = new Client(_character, _ipAddr);
                Close();
                gameWindow.Show();
            }
        }

        private void charactersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character = ((ComboBoxObject)charactersComboBox.SelectedItem).Key;
            Debug.WriteLine(_character);
        }

        private void charactersComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
