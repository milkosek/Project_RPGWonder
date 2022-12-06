using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class JoinSession : Form
    {
        public JoinSession()
        {
            InitializeComponent();
        }

        public Game Game
        {
            get => default;
            set
            {
            }
        }

        private void JoinSession_Load(object sender, EventArgs e)
        {
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\characters";
            if (File.Exists(path + "\\00_Characters.json"))
            {
                JObject data = JObject.Parse(File.ReadAllText(path + "\\00_Characters.json"));
                JArray characters = (JArray)data["characters"];
                foreach (JToken characterTAG in characters)
                {
                    JObject character = JObject.Parse(File.ReadAllText(path + characterTAG.ToString()));
                    charactersComboBox.Items.Add((string)character["name"]);
                }
            }
            else
            {
                string message = "00_Characters.json file seems to missing or corrupted.\nCreating a new character should fix this issue.";
                MessageBox.Show(message);
                Close();
            }
        }

        private void JoinGameButton_Click(object sender, EventArgs e)
        {
            Game gameWindow = new Game();
            Close();
            gameWindow.Show();
        }
    }
}
