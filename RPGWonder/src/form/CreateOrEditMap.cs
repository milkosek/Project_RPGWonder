using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// Class representing a form for creating or editing a map.
    /// </summary>
    public partial class CreateOrEditMap : DefaultForm
    {
        private static CreateOrEditMap instance = null;
        internal bool _editing = false;
        internal Map _map = new Map();
        internal string _campaign;
        internal string _path;
        internal string _TAG;
        internal CreateOrEditCampaign _parent;

        /// <summary>
        /// Gets the instance of the <see cref="CreateOrEditMap"/> class with given parameters
        /// <param name="campaign">The campaign the map belongs to.</param>.
        /// <param name="parent">The parent form.</param>.
        /// </summary>
        public static CreateOrEditMap Instance(string campaign, CreateOrEditCampaign parent)
        {
            if (instance == null)
            {
                instance = new CreateOrEditMap(campaign, parent);
            }
            return instance;
        }

        private CreateOrEditMap(string campaign, CreateOrEditCampaign parent)
        {
            InitializeComponent();
            SetMotif();
            saveButton.BackColor = Color.SteelBlue;
            _campaign = campaign;
            _editing = false;
            _parent = parent;
            _path = Common.Instance.CampaignsPath + "\\" + campaign;
        }

        /// <summary>
        /// Public constructor creading an instance of the class for codex entry editing purposes.
        /// <param name="campaign">The campaign the map belongs to.</param>.
        /// <param name="parent">The parent form.</param>.
        /// <param name="path">The path to the edited map.</param>
        /// </summary>
        public CreateOrEditMap(string campaign, CreateOrEditCampaign parent, string path)
        {
            Debug.WriteLine(campaign);
            Debug.WriteLine(path);
            InitializeComponent();
            SetMotif();
            saveButton.BackColor = Color.SteelBlue;
            _campaign = campaign;
            _editing = true;
            _parent = parent;
            _path = path;
            _map.ReadFromJSON(path);
            nameTextBox.Text = _map.Name;
            rowsNumericUpDown.Value = _map.Rows;
            columnsNumericUpDown.Value = _map.Columns;
            _TAG = Path.GetFileName(path);
            if (_TAG.EndsWith(".json"))
                _TAG = _TAG.Remove(_TAG.Length - 5);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Map name cannot be empty!");
            }
            else
            {
                long maxID = 0;
                string[] filePaths = Directory.GetFiles(_path + "\\maps", "*.json");
                foreach (string filePath in filePaths)
                {
                    try
                    {
                        JObject map = JObject.Parse(File.ReadAllText(filePath));
                        if ((long)map["Id"] > maxID)
                        {
                            maxID = (long)map["Id"];
                        }
                    }
                    catch (Exception exception)
                    {
                        Log.Instance.errorLog.Error("Couldn't read " + filePath + " Error: " + exception.Message);
                    }
                }
                _map.Name = nameTextBox.Text;
                _map.Rows = (int)rowsNumericUpDown.Value;
                _map.Id = maxID + 1;
                _map.Columns = (int)columnsNumericUpDown.Value;
                save();
                MessageBox.Show("Saved!");
                _parent.Reload();
                Close();
            }
        }

        private void save()
        {
            Log.Instance.gameLog.Debug("Trying to save: " + _map.Name);
            if (!_editing)
            {
                _TAG = _map.Name;
                string newTAG = _TAG;
                int counter = 1;
                while (File.Exists(Common.Instance.CampaignsPath + "\\" + _campaign + "\\maps\\" + newTAG + ".json"))
                {
                    Log.Instance.errorLog.Error("Map with TAG " + newTAG + "already exists!");
                    newTAG = $"{_TAG}({counter})";
                    counter++;
                }
                _TAG = newTAG;
            }
            try
            {
                _map.SaveToJSON(Common.Instance.CampaignsPath + "\\" + _campaign + "\\maps", _TAG);
                Log.Instance.gameLog.Debug("Saved map: " + _TAG);
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Failed to save map: " + _TAG + " Error: " + exception.Message);
            }
        }

        private void CreateOrEditMap_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}
