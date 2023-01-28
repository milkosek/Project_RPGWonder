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
    public partial class ShowCodex : DefaultForm
    {
        private static ShowCodex _instance = null;
        private Campaign _campaign;

        public static ShowCodex Instance(Campaign campaign)
        {
            if (_instance == null)
            {
                _instance = new ShowCodex(campaign);
            }
            return _instance; 
        }

        public ShowCodex(Campaign campaign)
        {
            _campaign = campaign;
            InitializeComponent();
        }

        private void ShowCodex_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            SetMotif();
            foreach (KeyValuePair<string, CodexEntry> codexEntry in _campaign.CodexEntries)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject
                {
                    Key = codexEntry.Value.Text,
                    Value = codexEntry.Value.Title
                };
                listBox.Items.Add(comboBoxObject);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItems != null)
            {
                titleTextBox.Text = ((ComboBoxObject)listBox.SelectedItem).Value;
                textTextBox.Text = ((ComboBoxObject)listBox.SelectedItem).Key;
            }
        }
    }
}
