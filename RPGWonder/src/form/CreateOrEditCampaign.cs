using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class CreateOrEditCampaign : Form
    {
        private string _campaignName;

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
            if (string.IsNullOrEmpty(_campaignName))
            {
                string message = "Campaign name cannot be empty!";
                MessageBox.Show(message);
            }
            else
            {
                if (!Directory.Exists("./userdata/Campaigns"))
                {
                    Directory.CreateDirectory("./userdata/Campaigns");
                }
                _campaignName = _campaignName.Trim();
                string path = "./userdata/Campaigns/" + _campaignName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Directory.CreateDirectory(path + "/Characters");
                    Directory.CreateDirectory(path + "/Maps");
                    Directory.CreateDirectory(path + "/Assets");
                    ManageCampaigns.instance.Reload();
                }
                string message = "Campaign saved!";
                MessageBox.Show(message);
            }
        }

        private void CampaignNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _campaignName = CampaignNameTextBox.Text;
        }
    }
}
