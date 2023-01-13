using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
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
        internal Campaign campaign = new Campaign();
        internal string TAG;
        internal string _page = "codex";
        private string _path;
        private bool _editing = false;
        private CreateOrEditCampaign()
        {
            InitializeComponent();
            SetMotif();
            SetColors();
        }
        public CreateOrEditCampaign(string path)
        {
            InitializeComponent();
            SetMotif();
            SetColors();
            _path = path;
            _editing = true;
            swapToPage2();
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
                MessageBox.Show("Campaign name cannot be empty!");
            }
            else
            {
                save();
                swapToPage2();
                Close();
                MessageBox.Show("Campaign saved!");
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (_page == "codex")
            {
                CreateOrEditCodexEntry.Instance(TAG, this).Show();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            campaign.Name = CampaignNameTextBox.Text;
            if (string.IsNullOrEmpty(campaign.Name))
            {
                MessageBox.Show("Campaign name cannot be empty!");
            }
            else
            {
                save();
                _editing = true;
                swapToPage2();
            }
        }

        private void save()
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
            Directory.CreateDirectory(Common.Instance.CampaignsPath + "\\" + TAG + "\\codex");
            campaign.SaveToJSON(Common.Instance.CampaignsPath, TAG);
        }

        private void swapToPage2()
        {
            createButton.Visible = false;
            addButton.Visible = true;
            editButton.Visible = true;
            deleteButton.Visible = true;
            SaveButton.Visible = true;
            listBox.Visible = true;
            Reload();
        }

        private void SetColors()
        {
            addButton.BackColor = Color.SeaGreen;
            createButton.BackColor = Color.SeaGreen;
            editButton.BackColor = Color.SteelBlue;
            SaveButton.BackColor = Color.SteelBlue;
            deleteButton.BackColor = Color.IndianRed;
        }

        public void Reload()
        {
            if (_page == "codex")
            {
                listBox.Items.Clear();
                if (Directory.Exists(_path + "\\codex"))
                {
                    string[] filePaths = Directory.GetFiles(_path + "\\codex", "*.json");
                    foreach (string filePath in filePaths)
                    {
                        JObject codexEntry = JObject.Parse(File.ReadAllText(filePath));
                        ComboBoxObject comboBoxObject = new ComboBoxObject(filePath, (string)codexEntry["Title"]);
                        listBox.Items.Add(comboBoxObject);
                    }
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                File.Delete(((ComboBoxObject)listBox.SelectedItem).Key);
                Reload();
            }
            listBox.SelectedItem = null;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (_page == "codex")
            {
                CreateOrEditCodexEntry createOrEditCodexEntry = new CreateOrEditCodexEntry(TAG, this, ((ComboBoxObject)listBox.SelectedItem).Key);
                createOrEditCodexEntry.Show();
            }
        }
    }
}
