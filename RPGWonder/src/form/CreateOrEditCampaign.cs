using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// Singleton class repesenting a form for for creating or editing campaign.
    /// </summary>
    public partial class CreateOrEditCampaign : DefaultForm
    {

        private static CreateOrEditCampaign _instance = null;

        /// <summary>
        /// Gets the instance of the <see cref="CreateOrEditCampaign"/> class.
        /// </summary>
        public static CreateOrEditCampaign Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CreateOrEditCampaign();
                }
                return _instance;
            }
        }
        internal Campaign _campaign = new Campaign();
        internal string _TAG;
        internal string _page = "codex";
        private string _path;
        private bool _editing = false;

        private Map defaultMap;

        private CreateOrEditCampaign()
        {
            InitializeComponent();
            SetMotif();
            SetColors();
        }

        /// <summary>
        /// Public constructor creading an instance of the class for campaign editing purposes.
        /// <param name="path">The path to the edited campaign.</param>
        /// </summary>
        public CreateOrEditCampaign(string path)
        {
            InitializeComponent();
            SetMotif();
            SetColors();
            _path = path;
            _editing = true;
            swapToPage2();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _campaign.Name = CampaignNameTextBox.Text;
            if (string.IsNullOrEmpty(_campaign.Name))
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

        private void CreateOrEditCampaign_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            if (_editing)
            {
                string[] parts = _path.Split('\\');
                _TAG = parts[parts.Length - 1];
                _campaign.ReadFromJSON(_path + "\\" + _TAG + ".json");
                CampaignNameTextBox.Text = _campaign.Name;
                Log.Instance.gameLog.Debug("Editing campaign: " + _campaign.Name);
            } 
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (_page == "codex")
            {
                CreateOrEditCodexEntry.Instance(_TAG, this).Show();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _campaign.Name = CampaignNameTextBox.Text;
            if (string.IsNullOrEmpty(_campaign.Name))
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
            Log.Instance.gameLog.Debug("Trying to save campaign: " + _campaign.Name);
            if (!_editing)
            {
                _TAG = _campaign.Name;
                string newTAG = _TAG;
                int counter = 1;
                while (Directory.Exists(Common.Instance.CampaignsPath + "\\" + newTAG))
                {
                    Log.Instance.errorLog.Error("Campaign with _TAG " + newTAG + "already exists!");
                    newTAG = $"{_TAG}({counter})";
                    counter++;
                }
                _TAG = newTAG;
            }

            if (!Directory.Exists(Common.Instance.CampaignsPath + "\\" + _TAG + "\\maps"))
            {
                Directory.CreateDirectory(Common.Instance.CampaignsPath + "\\" + _TAG + "\\maps");
                Log.Instance.gameLog.Debug("Created folder: " + Common.Instance.CampaignsPath + "\\" + _TAG + "\\maps");

                defaultMap = new Map() { Id = 0, Columns = 16, Rows = 12, Name = "DefaultMap" };
                defaultMap.SaveToJSON(Common.Instance.CampaignsPath + "\\" + _TAG + "\\maps\\" + "DefaultMap.json");
                Log.Instance.gameLog.Debug("Created default map in folder: " + Common.Instance.CampaignsPath + "\\" + _TAG + "\\maps");
            }

            if (!Directory.Exists(Common.Instance.CampaignsPath + "\\" + _TAG + "\\codex"))
            {
                Directory.CreateDirectory(Common.Instance.CampaignsPath + "\\" + _TAG + "\\codex");
                Log.Instance.gameLog.Debug("Created folder: " + Common.Instance.CampaignsPath + "\\" + _TAG + "\\codex");
            }

            if (!Directory.Exists(Common.Instance.CampaignsPath + "\\" + _TAG + "\\characters"))
            {
                Directory.CreateDirectory(Common.Instance.CampaignsPath + "\\" + _TAG + "\\characters");
                Log.Instance.gameLog.Debug("Created folder: " + Common.Instance.CampaignsPath + "\\" + _TAG + "\\characters");
            }

            if (!Directory.Exists(Common.Instance.CampaignsPath + "\\" + _TAG + "\\assets"))
            {
                Directory.CreateDirectory(Common.Instance.CampaignsPath + "\\" + _TAG + "\\assets");
                Log.Instance.gameLog.Debug("Created folder: " + Common.Instance.CampaignsPath + "\\" + _TAG + "\\assets");
            }

            if (!Directory.Exists(Common.Instance.CampaignsPath + "\\" + _TAG + "\\entityAssets"))
            {
                Directory.CreateDirectory(Common.Instance.CampaignsPath + "\\" + _TAG + "\\entityAssets");
                Log.Instance.gameLog.Debug("Created folder: " + Common.Instance.CampaignsPath + "\\" + _TAG + "\\entityAssets");

                File.Copy(Properties.Settings.Default.Path + "src\\asset\\chest.png", Common.Instance.CampaignsPath + "\\" + _TAG + "\\entityAssets\\chest.png", true);
                File.Copy(Properties.Settings.Default.Path + "src\\asset\\knight.png", Common.Instance.CampaignsPath + "\\" + _TAG + "\\entityAssets\\knight.png", true);
                File.Copy(Properties.Settings.Default.Path + "src\\asset\\wall.png", Common.Instance.CampaignsPath + "\\" + _TAG + "\\entityAssets\\wall.png", true);
            }

            try
            {
                _campaign.SaveToJSON(Common.Instance.CampaignsPath, _TAG);
                Log.Instance.gameLog.Debug("Saved campaign: " + _TAG);
                _path = Common.Instance.CampaignsPath + "\\" + _TAG;
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Failed to save campaign: " + _TAG + " Error: " + exception.Message);
            }
        }

        private void swapToPage2()
        {
            createButton.Enabled = false;
            addButton.Enabled = true;
            SaveButton.Enabled = true;
            listBox.Enabled = true;
            Reload();
        }

        private void SetColors()
        {
            addButton.BackColor = Color.SeaGreen;
            createButton.BackColor = Color.SeaGreen;
            editButton.BackColor = Color.SteelBlue;
            SaveButton.BackColor = Color.SteelBlue;
            deleteButton.BackColor = Color.IndianRed;
            addAsset.BackColor = Color.SeaGreen;
            removeAsset.BackColor = Color.IndianRed;
        }

        /// <summary> 
        /// Reload the instance of the class, repopulating the list box.
        /// </summary>
        public void Reload()
        {
            Debug.WriteLine(_path + "\\codex");
            Log.Instance.gameLog.Debug("CreateOrEditCampaign: Reloading...");
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
                Log.Instance.gameLog.Debug("Trying to delete codex entry: " + ((ComboBoxObject)listBox.SelectedItem).Key);
                try
                {
                    string toDelete = ((ComboBoxObject)listBox.SelectedItem).Key;
                    File.Delete(toDelete);
                    Reload();
                    listBox.SelectedItem = null;
                    editButton.Enabled = false;
                    deleteButton.Enabled = false;
                    Log.Instance.gameLog.Debug("Deleted codex entry: " + toDelete);
                }
                catch (Exception exception)
                {
                    Log.Instance.errorLog.Error("Failed to delete codex entry: " + ((ComboBoxObject)listBox.SelectedItem).Key + " Error: " + exception.Message);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (_page == "codex")
            {
                CreateOrEditCodexEntry createOrEditCodexEntry = new CreateOrEditCodexEntry(_TAG, this, ((ComboBoxObject)listBox.SelectedItem).Key);
                createOrEditCodexEntry.Show();
            }
        }

        private void addAsset_Click(object sender, EventArgs e)
        {
            string assetPath = string.Empty;
            string targetPath = _path + "\\assets\\";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    assetPath = openFileDialog.FileName;
                    targetPath = targetPath + System.IO.Path.GetFileName(assetPath);
                    try
                    {
                        File.Copy(assetPath, targetPath);
                        Log.Instance.gameLog.Debug("File copied successfully.");
                    }
                    catch (IOException exception)
                    {
                        Log.Instance.errorLog.Error("An error occurred: " + exception.Message);
                    }
                    Asset asset = new Asset(targetPath);
                }
            }
        }
        private void removeAsset_Click(object sender, EventArgs e)
        {
            string assetPath = string.Empty;
            string targetPath = _path + "\\assets\\";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = targetPath;
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    assetPath = openFileDialog.FileName;
                    try
                    {
                        if(assetPath.Contains(System.IO.Path.GetFullPath(targetPath)))
                        {
                            File.Delete(assetPath);
                            Log.Instance.gameLog.Debug("File deleted successfully.");
                        }
                        else
                        {
                            Log.Instance.errorLog.Error("You chose a file outside of assets");
                        }
                    }
                    catch (IOException exception)
                    {
                        Log.Instance.errorLog.Error("An error occurred: " + exception.Message);
                    }
                }
            }
        }
    }
}
