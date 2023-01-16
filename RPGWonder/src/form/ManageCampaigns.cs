using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RPGWonder
{
    /// <summary>
    /// A form for managing campaigns
    /// </summary>
    public partial class ManageCampaigns : DefaultForm
    {
        private static ManageCampaigns instance = null;
        public static ManageCampaigns Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageCampaigns();
                }
                return instance;
            }
        }

        /// <summary>
        /// Initializes a new instance of the ManageCampaigns class.
        /// </summary>
        private ManageCampaigns()
        {
            InitializeComponent();
            SetMotif();
            editCampaignButton.BackColor = Color.SteelBlue;
            deleteCampaignButton.BackColor = Color.IndianRed;
            createCampaignButton.BackColor = Color.SeaGreen;
            CrtNewCampaignButton.BackColor = Color.SeaGreen;
            LoadCampaignButton.BackColor = Color.SteelBlue;
            instance = this;
        }

        /// <summary>
        /// Reloads the list of campaigns from the ./userdata/Campaigns directory.
        /// </summary>
        public void Reload()
        {
            manageCampaignsListBox.Items.Clear();
            string path = Properties.Settings.Default.Path + "userData\\" + Properties.Settings.Default.System + "\\campaigns";
            string[] campaigns;
            if (Directory.Exists(path))
            {
                campaigns = Directory.GetDirectories(path);
            }
            else
            {
                campaigns = new string[0];
            }
            foreach (string campaign in campaigns)
            {
                string campaignTAG = campaign.Split('\\').Last();
                string jsonString = File.ReadAllText(path + "\\" + campaignTAG + "\\" + campaignTAG + ".json");
                JObject json = JObject.Parse(jsonString);
                ComboBoxObject comboBoxObject = new ComboBoxObject
                {
                    Key = path + "\\" + campaignTAG,
                    Value = (string)json["Name"]
                };
                manageCampaignsListBox.Items.Add(comboBoxObject);
            }
        }

        /// <summary>
        /// Handles the Load event of the ManageCampaigns form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void ManageCampaigns_Load(object sender, EventArgs e)
        {
            Reload();
        }

        /// <summary>
        /// Handles the Click event of the CrtNewCampaignButton button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void CrtNewCampaignButton_Click(object sender, EventArgs e)
        {
            goToCreateNew();
        }
        /// <summary>
        /// Handles the Click event of the LoadCampaignButton button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void LoadCampaignButton_Click(object sender, EventArgs e)
        {
            swapToPage2();
        }

        public void swapToPage2()
        {
            LoadCampaignButton.Hide();
            CrtNewCampaignButton.Hide();
            manageCampaignsListBox.Show();
            editCampaignButton.Show();
            deleteCampaignButton.Show();
            createCampaignButton.Show();
        }

        private void editCampaignButton_Click(object sender, EventArgs e)
        {
            CreateOrEditCampaign createOrEditCampaign = new CreateOrEditCampaign(((ComboBoxObject)manageCampaignsListBox.SelectedItem).Key);
            createOrEditCampaign.Show();
        }

        private void manageCampaignsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (manageCampaignsListBox.SelectedItem != null)
            {
                editCampaignButton.Enabled = true;
                deleteCampaignButton.Enabled = true;
            }
        }

        private void deleteCampaignButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Directory.Delete(((ComboBoxObject)manageCampaignsListBox.SelectedItem).Key, true);
                Reload();
            }
            manageCampaignsListBox.SelectedItem = null;
            editCampaignButton.Enabled = false;
            deleteCampaignButton.Enabled = false;
        }

        private void createCampaignButton_Click(object sender, EventArgs e)
        {
            goToCreateNew();
        }

        private void goToCreateNew()
        {
            CreateOrEditCampaign.Instance.Show();
            Close();
        }
    }
}
