using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class CreateOrEditCampaign : DefaultForm
    {
        private static CreateOrEditCampaign instance = null;
        public static CreateOrEditCampaign Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreateOrEditCampaign();
                }
                return instance;
            }
        }
        /// <summary>
        /// The campaign that is being created or edited by this form.
        /// </summary>
        internal Campaign campaign = new Campaign();
        internal string TAG;
        private string _path;
        private bool _editing = false;
        /// <summary>
        /// Constructs a new instance of the `CreateOrEditCampaign` class.
        /// </summary>
        private CreateOrEditCampaign()
        {
            InitializeComponent();
            SetMotif();
        }
        public CreateOrEditCampaign(string path)
        {
            InitializeComponent();
            SetMotif();
            _path = path;
            _editing = true;
        }
        /// <summary>
        /// Handles the click event for the `SaveButton` button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            campaign.Name = CampaignNameTextBox.Text;
            if (string.IsNullOrEmpty(campaign.Name))
            {
                string message = "Campaign name cannot be empty!";
                MessageBox.Show(message);
            }
            else
            {
                if (!_editing)
                {
                    TAG = campaign.Name;
                    string newTAG = TAG;
                    int counter = 1;
                    while (Directory.Exists(Common.Instance.CampaignsPath + "\\" + newTAG))
                    {
                        newTAG = $"{TAG}({counter})";
                        counter++;
                    }
                    TAG = newTAG;
                }
                campaign.SaveToJSON(Common.Instance.CampaignsPath, TAG);
                string message = "Campaign saved!";
                ManageCampaigns.Instance.Reload();
                MessageBox.Show(message);
                ManageCampaigns.Instance.Show();
                ManageCampaigns.Instance.swapToPage2();
                Close();
            }
        }

        /// <summary>
        /// Handles the `Load` event for the `CreateOrEditCampaign` form.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CreateOrEditCampaign_Load(object sender, EventArgs e)
        {
            if (_editing)
            {
                string[] parts = _path.Split('\\');
                TAG = parts[parts.Length - 1];
                campaign.ReadFromJSON(_path + "\\" + TAG + ".json");
                CampaignNameTextBox.Text = campaign.Name;
            } 
        }

        protected override void Dispose(bool disposing)
        {
            instance = null;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
