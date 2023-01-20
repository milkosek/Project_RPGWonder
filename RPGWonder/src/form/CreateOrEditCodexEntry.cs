using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// Class representing a form for creating or editing a codex entry.
    /// </summary>
    public partial class CreateOrEditCodexEntry : DefaultForm
    {
        private static CreateOrEditCodexEntry instance = null;
        internal bool _editing = false;
        internal CodexEntry _codexEntry = new CodexEntry();
        internal string _campaign;
        internal string _path;
        internal string _TAG;
        internal CreateOrEditCampaign _parent;

        /// <summary>
        /// Gets the instance of the <see cref="CreateOrEditCodexEntry"/> class with given parameters
        /// <param name="campaign">The campaign the codex entry belongs to.</param>.
        /// <param name="parent">The parent form.</param>.
        /// </summary>
        public static CreateOrEditCodexEntry Instance(string campaign, CreateOrEditCampaign parent)
        {
            if (instance == null)
            {
                instance = new CreateOrEditCodexEntry(campaign, parent);
            }
            return instance;
        }

        private CreateOrEditCodexEntry(string campaign, CreateOrEditCampaign parent)
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
        public CreateOrEditCodexEntry(string campaign, CreateOrEditCampaign parent, string path)
        {
            InitializeComponent();
            SetMotif();
            saveButton.BackColor = Color.SteelBlue;
            _campaign = campaign;
            _editing = true;
            _parent = parent;
            _path = path;
            _codexEntry.ReadFromJSON(path);
            codexEntryTitleTextBox.Text = _codexEntry.Title;
            codexEntryTextTextBox.Text = _codexEntry.Text;
            _TAG = Path.GetFileName(path);
            if (_TAG.EndsWith(".json"))
                _TAG = _TAG.Remove(_TAG.Length - 5);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (codexEntryTitleTextBox.Text == "")
            {
                MessageBox.Show("Entry title cannot be empty!");
            }
            else
            {
                _codexEntry.Title = codexEntryTitleTextBox.Text;
                _codexEntry.Text = codexEntryTextTextBox.Text;
                save();
                MessageBox.Show("Saved!");
                _parent.Reload();
                Close();
            }
        }

        private void save()
        {
            Log.Instance.gameLog.Debug("Trying to save: " + _codexEntry.Title);
            if (!_editing)
            {
                _TAG = _codexEntry.Title;
                string newTAG = _TAG;
                int counter = 1;
                while (File.Exists(Common.Instance.CampaignsPath + "\\" + _campaign + "\\codex\\" + newTAG + ".json"))
                {
                    Log.Instance.errorLog.Error("Codex entry with TAG " + newTAG + "already exists!");
                    newTAG = $"{_TAG}({counter})";
                    counter++;
                }
                _TAG = newTAG;
            }
            try
            {
                _codexEntry.SaveToJSON(Common.Instance.CampaignsPath + "\\" + _campaign + "\\codex", _TAG);
                Log.Instance.gameLog.Debug("Saved codex entry: " + _TAG);
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Failed to save codex entry: " + _TAG + " Error: " + exception.Message);
            }
        }

        private void CreateOrEditCodexEntry_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}
