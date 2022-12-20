using System;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class CreateOrEditCampaign : Form
    {
        /// <summary>
        /// The campaign that is being created or edited by this form.
        /// </summary>
        internal Campaign campaign;
        /// <summary>
        /// Constructs a new instance of the `CreateOrEditCampaign` class.
        /// </summary>
        public CreateOrEditCampaign()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Gets or sets the `MapEditor` instance associated with this form.
        /// </summary>
        public MapEditor MapEditor
        {
            get => default;
            set
            {
            }
        }
        /// <summary>
        /// Gets or sets the `Campaign` instance associated with this form.
        /// </summary>
        internal Campaign Campaign
        {
            get => default;
            set
            {
            }
        }
        /// <summary>
        /// Gets or sets the `ManageCharacters` instance associated with this form.
        /// </summary>
        public ManageCharacters ManageCharacters
        {
            get => default;
            set
            {
            }
        }
        /// <summary>
        /// Handles the click event for the `SaveButton` button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
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
        /// <summary>
        /// Handles the `TextChanged` event for the `CampaignNameTextBox` text box.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CampaignNameTextBox_TextChanged(object sender, EventArgs e)
        {
            campaign.Name = CampaignNameTextBox.Text.Trim();
        }
        /// <summary>
        /// Handles the `Load` event for the `CreateOrEditCampaign` form.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CreateOrEditCampaign_Load(object sender, EventArgs e)
        {
            campaign = new Campaign();
        }
    }
}
