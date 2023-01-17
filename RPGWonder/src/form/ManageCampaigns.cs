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
        private static ManageCampaigns _instance = null;
        public static ManageCampaigns Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManageCampaigns();
                }
                return _instance;
            }
        }

        private ManageCampaigns()
        {
            InitializeComponent();
            SetMotif();
            editCampaignButton.BackColor = Color.SteelBlue;
            deleteCampaignButton.BackColor = Color.IndianRed;
            createCampaignButton.BackColor = Color.SeaGreen;
            CrtNewCampaignButton.BackColor = Color.SeaGreen;
            LoadCampaignButton.BackColor = Color.SteelBlue;
            _instance = this;
        }

        /// <summary>
        /// Reloads the list of campaigns from the ./userdata/campaigns directory.
        /// </summary>
        public void Reload()
        {
            Log.Instance.gameLog.Debug("ManageCampaigns: Reloading...");
            manageCampaignsListBox.Items.Clear();
            string path = Properties.Settings.Default.Path + "userData\\" + Properties.Settings.Default.System + "\\campaigns";
            string[] campaigns;
            if (Directory.Exists(path))
            {
                campaigns = Directory.GetDirectories(path);
            }
            else
            {
                Log.Instance.errorLog.Error("Directory " + path + " not found!");
                campaigns = new string[0];
            }
            foreach (string campaign in campaigns)
            {
                string campaignTAG = campaign.Split('\\').Last();
                try
                {
                    string jsonString = File.ReadAllText(path + "\\" + campaignTAG + "\\" + campaignTAG + ".json");
                    JObject json = JObject.Parse(jsonString);
                    ComboBoxObject comboBoxObject = new ComboBoxObject
                    {
                        Key = path + "\\" + campaignTAG,
                        Value = (string)json["Name"]
                    };
                    manageCampaignsListBox.Items.Add(comboBoxObject);
                }
                catch (Exception exception)
                {
                    Log.Instance.errorLog.Error("Cannot load " + path + "\\" + campaignTAG + "\\" + campaignTAG + ".json." + " Error: " + exception.Message);
                }
            }
        }

        private void ManageCampaigns_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void CrtNewCampaignButton_Click(object sender, EventArgs e)
        {
            goToCreateNew();
        }

        private void LoadCampaignButton_Click(object sender, EventArgs e)
        {
            swapToPage2();
        }

        /// <summary>
        /// Swaps to the second page of the manager (the proper management).
        /// </summary>
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
                try
                {
                    string toDelete = ((ComboBoxObject)manageCampaignsListBox.SelectedItem).Key;
                    Directory.Delete(toDelete, true);
                    Reload();
                    Log.Instance.gameLog.Debug(toDelete + " deleted succesfully.");
                    manageCampaignsListBox.SelectedItem = null;
                    editCampaignButton.Enabled = false;
                    deleteCampaignButton.Enabled = false;
                }
                catch(Exception exception)
                {
                    Log.Instance.errorLog.Error("Cannot delete " + ((ComboBoxObject)manageCampaignsListBox.SelectedItem).Key + " Error: " + exception.Message);
                }
            }
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
