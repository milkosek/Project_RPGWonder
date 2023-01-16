using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class CreateOrEditCodexEntry : DefaultForm
    {
        private static CreateOrEditCodexEntry instance = null;
        internal bool _editing = false;
        internal CodexEntry _codexEntry = new CodexEntry();
        internal string _campaign;
        internal string _path;
        internal string TAG;
        internal CreateOrEditCampaign _parent;
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
            TAG = Path.GetFileName(path);
            if (TAG.EndsWith(".json"))
                TAG = TAG.Remove(TAG.Length - 5);
            Debug.WriteLine(TAG);
        }

        private void saveButton_Click(object sender, System.EventArgs e)
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
            if (!_editing)
            {
                TAG = _codexEntry.Title;
                string newTAG = TAG;
                int counter = 1;
                while (File.Exists(Common.Instance.CampaignsPath + "\\" + _campaign + "\\codex\\" + newTAG + ".json"))
                {
                    newTAG = $"{TAG}({counter})";
                    counter++;
                }
                TAG = newTAG;
            }
            _codexEntry.SaveToJSON(Common.Instance.CampaignsPath + "\\" + _campaign + "\\codex", TAG);
        }
    }
}
