using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// This class represents a form for hosting a new game session.
    /// </summary>
    public partial class HostSession : DefaultForm
    {
        private static HostSession instance = null;
        public static HostSession Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HostSession();
                }
                return instance;
            }
        }
        private string _campaign = "";
        /// <summary>
        /// Initializes a new instance of the `HostSession` class.
        /// </summary>
        private HostSession()
        {
            InitializeComponent();
            SetMotif();
        }

        /// <summary>
        /// This method is called when the `hostSessionButton` is clicked. It creates a new `Game` object,
        /// closes the `HostSession` form, and shows the `Host` form.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void hostSessionButton_Click(object sender, EventArgs e)
        {
            Host host = new Host(_campaign);
            Close();
            host.Show();
            //MainMenu.instance.Hide();
        }

        /// <summary>
        /// This method is called when the `HostSession` form is loaded. It reads the list of campaigns
        /// from a JSON file and adds them to the `selectCampaignComboBox` control.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void HostSession_Load(object sender, EventArgs e)
        {
            myIPTextBox.Text = IPAdd.GetMyIPAddress().ToString();
            string[] subdirectoryPaths = Directory.GetDirectories(Common.Instance.CampaignsPath);

            foreach (string subdirectoryPath in subdirectoryPaths)
            {
                string[] filePaths = Directory.GetFiles(subdirectoryPath, "*.json");
                foreach (string filePath in filePaths)
                {
                    JObject campaign = JObject.Parse(File.ReadAllText(filePath));
                    ComboBoxObject comboBoxObject = new ComboBoxObject(filePath, (string)campaign["Name"]);
                    selectCampaignComboBox.Items.Add(comboBoxObject);
                }
            }
        }

        private void selectCampaignComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _campaign = ((ComboBoxObject)selectCampaignComboBox.SelectedItem).Key;
        }
    }
}
