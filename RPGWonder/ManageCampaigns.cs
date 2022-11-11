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
    public partial class ManageCampaigns : Form
    {
        public ManageCampaigns()
        {
            InitializeComponent();
        }

        public CreateOrEditCampaign CreateOrEditCampaign
        {
            get => default;
            set
            {
            }
        }

        private void ManageCampaigns_Load(object sender, EventArgs e)
        {

        }
    }
}
