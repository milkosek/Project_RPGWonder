using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class CreateOrEditCampaign : DefaultForm
    {
        /// <summary>
        /// The campaign that is being created or edited by this form.
        /// </summary>
        internal Campaign campaign = new Campaign();
        internal string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns";
        internal string TAG;
        private string _path;
        private bool _editing = false;
        /// <summary>
        /// Constructs a new instance of the `CreateOrEditCampaign` class.
        /// </summary>
        public CreateOrEditCampaign()
        {
            InitializeComponent();
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
                    while (Directory.Exists(path + "\\" + newTAG))
                    {
                        newTAG = $"{TAG}({counter})";
                        counter++;
                    }
                    TAG = newTAG;
                    Debug.WriteLine("tu");
                    Debug.WriteLine(path + "\\" + TAG);
                }
                campaign.SaveToJSON(path, TAG);
                string message = "Campaign saved!";
                ManageCampaigns.instance.Reload();
                MessageBox.Show(message);
                ManageCampaigns manageCampaigns = new ManageCampaigns();
                manageCampaigns.Show();
                manageCampaigns.swapToPage2();
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
    }
}
