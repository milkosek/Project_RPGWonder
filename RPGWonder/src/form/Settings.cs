using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class Settings : DefaultForm
    {
        private static Settings instance = null;
        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                }
                return instance;
            }
        }
        private Settings()
        {
            InitializeComponent();
            SetMotif();
            saveButton.BackColor = Color.SteelBlue;
        }

        private void Settings_Load(object sender, System.EventArgs e)
        {
            pathTextBox.Text = Properties.Settings.Default.Path;
            systemComboBox.Text = Properties.Settings.Default.System;
            string path = Properties.Settings.Default.Path + "systemPresets";
            string[] campaigns;
            if (Directory.Exists(path))
            {
                campaigns = Directory.GetDirectories(path);
            }
            else
            {
                campaigns = new string[0];
            }
            foreach (string campaign in campaigns)
            {
                systemComboBox.Items.Add(Path.GetFileName(campaign));
            }
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.Path = pathTextBox.Text;
            Properties.Settings.Default.System = systemComboBox.Text;
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
