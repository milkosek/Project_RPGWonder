using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class HostSession : Form
    {
        private Dictionary<string, string> campaigns = new Dictionary<string, string>();
        public HostSession()
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

        private void hostSessionButton_Click(object sender, EventArgs e)
        {
            Game gameWindow = new Game();
            Close();
            gameWindow.Show();
        }

        private void HostSession_Load(object sender, EventArgs e)
        {
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns";
            if (File.Exists(path + "\\00_Campaigns.json"))
            {
                JObject data = JObject.Parse(File.ReadAllText(path + "\\00_Campaigns.json"));
                JArray campaigns = (JArray)data["campaigns"];
                foreach (JToken campaignTAG in campaigns)
                {
                    JObject campaign = JObject.Parse(File.ReadAllText(path + campaignTAG.ToString()));
                    selectCampaignComboBox.Items.Add((string)campaign["name"]);
                }
            }
            else
            {
                string message = "00_Campaigns.json file seems to missing or corrupted.\nCreating a new campaign should fix this issue.";
                MessageBox.Show(message);
                Close();
            }
        }
    }
}
