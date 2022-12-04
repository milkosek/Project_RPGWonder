using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class ManageCampaigns : Form
    {
        public static ManageCampaigns instance;
        public ManageCampaigns()
        {
            InitializeComponent();
            instance = this;
        }

        public CreateOrEditCampaign CreateOrEditCampaign
        {
            get => default;
            set
            {
            }
        }

        public void Reload()
        {
            ManageCampaignsListBox.Items.Clear();
            string path = "./userdata/Campaigns";
            string[] campaigns = new string[0];
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
                string campaign_name = campaign.Split('\\').Last();

                ManageCampaignsListBox.Items.Add(campaign_name);
            }
        }

        private void ManageCampaigns_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void CrtNewCampaignButton_Click(object sender, EventArgs e)
        {
            CreateOrEditCampaign createOrEditCampaign = new CreateOrEditCampaign();
            createOrEditCampaign.Show();
            Hide();
        }

        private void ManageCampaignsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CreateOrEditCampaign createOrEditCampaign = new CreateOrEditCampaign();
            createOrEditCampaign.Show();
        }

        private void LoadCampaignButton_Click(object sender, EventArgs e)
        {
            LoadCampaignButton.Hide();
            CrtNewCampaignButton.Hide();
            ManageCampaignsListBox.Show();
        }
    }
}
