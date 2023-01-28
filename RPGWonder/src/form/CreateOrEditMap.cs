using System;
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
        /// <param name="campaign">The campaign the codex entry belongs to.</param>.
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
        }

        /// <summary>
        /// Public constructor creading an instance of the class for codex entry editing purposes.
        /// <param name="campaign">The campaign the codex entry belongs to.</param>.
        /// <param name="parent">The parent form.</param>.
        /// <param name="path">The path to the edited codex entry.</param>
        /// </summary>
        public CreateOrEditMap(string map, CreateOrEditCampaign parent, string path)
        {
            InitializeComponent();
            SetMotif();
            saveButton.BackColor = Color.SteelBlue;
            _campaign = map;
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
                _map.Name = nameTextBox.Text;
                _map.Rows = (int)rowsNumericUpDown.Value;
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
