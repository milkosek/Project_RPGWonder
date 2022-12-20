using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// This class represents a form for hosting a new game session.
    /// </summary>
    public partial class HostSession : Form
    {
        private string _campaign = "";
        /// <summary>
        /// Initializes a new instance of the `HostSession` class.
        /// </summary>
        public HostSession()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the `Game` object associated with this `HostSession` instance.
        /// </summary>
        public Client Game
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This method is called when the `hostSessionButton` is clicked. It creates a new `Game` object,
        /// closes the `HostSession` form, and shows the `Game` form.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void hostSessionButton_Click(object sender, EventArgs e)
        {
            Host host = new Host(_campaign);
            Close();
            host.Show();
            //MainMenu.instance.Hide();
        }

        /// <summary>
        /// This method is called when the `HostSession` form is loaded. It reads the list of campaigns
        /// from a JSON file and adds them to the `selectCampaignComboBox` control.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
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
                    ComboBoxObject comboBoxObject = new ComboBoxObject(campaignTAG.ToString(), (string)campaign["Name"]);
                    selectCampaignComboBox.Items.Add(comboBoxObject);
                }
            }
            else
            {
                string message = "00_Campaigns.json file seems to missing or corrupted.\nCreating a new campaign should fix this issue.";
                MessageBox.Show(message);
                Close();
            }
        }

        private void selectCampaignComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _campaign = ((ComboBoxObject)selectCampaignComboBox.SelectedItem).Key;
        }
    }
}
