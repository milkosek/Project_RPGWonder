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
    public partial class CreateCampaignPopup : Form
    {
        private string _campaignName;
        public CreateCampaignPopup()
        {
            InitializeComponent();
        }

        private void CreateCapaignPopupAcceptButton_Click(object sender, EventArgs e)
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
                if (Directory.Exists(path))
                {
                    string message = "Campaign already exists!\nPlease, choose a different name.";
                    MessageBox.Show(message);
                }
                else
                {
                    Directory.CreateDirectory(path);
                    Directory.CreateDirectory(path + "/Characters");
                    Directory.CreateDirectory(path + "/Entities");
                    Directory.CreateDirectory(path + "/Maps");
                    Directory.CreateDirectory(path + "/Assets");
                    string message = "Campaign created successfully!";
                    MessageBox.Show(message);
                    Close();
                }
            }
        }

        private void CreateCapaignPopupCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateCampaignPopupTextBox_TextChanged(object sender, EventArgs e)
        {
            _campaignName = CreateCampaignPopupTextBox.Text;
        }
    }
}
