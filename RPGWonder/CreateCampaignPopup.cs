using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class CreateCampaignPopup : Form
    {
        private String _campaignName;
        public CreateCampaignPopup()
        {
            InitializeComponent();
        }

        private void CreateCapaignPopupAcceptButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateCapaignPopupCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCampaignPopupTextBox_TextChanged(object sender, EventArgs e)
        {
            _campaignName = CreateCampaignPopupTextBox.Text;
        }
    }
}
