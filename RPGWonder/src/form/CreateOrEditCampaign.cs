using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class CreateOrEditCampaign : Form
    {
        private string campaignName;
        internal Campaign campaign;

        public CreateOrEditCampaign()
        {
            InitializeComponent();
        }

        public MapEditor MapEditor
        {
            get => default;
            set
            {
            }
        }

        internal Campaign Campaign
        {
            get => default;
            set
            {
            }
        }

        public ManageCharacters ManageCharacters
        {
            get => default;
            set
            {
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns";
            if (string.IsNullOrEmpty(campaign.Name))
            {
                string message = "Campaign name cannot be empty!";
                MessageBox.Show(message);
            }
            else
            {
                campaign.SaveToJSON(path);
                string message = "Campaign saved!";
                ManageCampaigns.instance.Reload();
                MessageBox.Show(message);
            }
        }

        private void CampaignNameTextBox_TextChanged(object sender, EventArgs e)
        {
            campaign.Name = CampaignNameTextBox.Text.Trim();
        }

        private void CreateOrEditCampaign_Load(object sender, EventArgs e)
        {
            campaign = new Campaign();
        }
    }
}
