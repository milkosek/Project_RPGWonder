using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// A form for managing campaigns
    /// </summary>
    public partial class ManageCampaigns : Form
    {
        /// <summary>
        /// An instance of the ManageCampaigns form.
        /// </summary>
        public static ManageCampaigns instance;

        /// <summary>
        /// Initializes a new instance of the ManageCampaigns class.
        /// </summary>
        public ManageCampaigns()
        {
            InitializeComponent();
            instance = this;
        }

        /// <summary>
        /// Gets or sets the CreateOrEditCampaign form.
        /// </summary>
        public CreateOrEditCampaign CreateOrEditCampaign
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Reloads the list of campaigns from the ./userdata/Campaigns directory.
        /// </summary>
        public void Reload()
        {
            manageCampaignsListBox.Items.Clear();
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

                manageCampaignsListBox.Items.Add(campaign_name);
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
            CreateOrEditCampaign createOrEditCampaign = new CreateOrEditCampaign();
            createOrEditCampaign.Show();
            Hide();
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of the ManageCampaignsListBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void ManageCampaignsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CreateOrEditCampaign createOrEditCampaign = new CreateOrEditCampaign();
            createOrEditCampaign.Show();
        }
        /// <summary>
        /// Handles the Click event of the LoadCampaignButton button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void LoadCampaignButton_Click(object sender, EventArgs e)
        {
            LoadCampaignButton.Hide();
            CrtNewCampaignButton.Hide();
            manageCampaignsListBox.Show();
        }
    }
}
