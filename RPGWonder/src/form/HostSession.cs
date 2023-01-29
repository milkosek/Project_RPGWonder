using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// Class representing a form for hosting a new game session.
    /// </summary>
    public partial class HostSession : DefaultForm
    {
        private static HostSession _instance = null;
        private string _campaign;
        public static HostSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HostSession();
                }
                return _instance;
            }
        }

        private HostSession()
        {
            InitializeComponent();
        }

        private void hostSessionButton_Click(object sender, EventArgs e)
        {
            Host host = new Host(_campaign, myIPTextBox.Text);
            Close();
            host.Show();
            //MainMenu._instance.Hide();
        }

        private void HostSession_Load(object sender, EventArgs e)
        {
            SetMotif();
            hostSessionButton.BackColor = Color.SteelBlue;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            string[] subdirectoryPaths = Directory.GetDirectories(Common.Instance.CampaignsPath);
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns";

            //myIPTextBox.Text = IPAdd.GetMyIPAddress().ToString();
            myIPTextBox.Text = "127.0.0.1";

            foreach (string subdirectoryPath in subdirectoryPaths)
            {
                string[] filePaths = Directory.GetFiles(subdirectoryPath, "*.json");
                foreach (string filePath in filePaths)
                {
                    try
                    {
                        Campaign testCampaign = new Campaign();
                        testCampaign.ReadFromJSON(filePath);
                        JObject campaign = JObject.Parse(File.ReadAllText(filePath));
                        ComboBoxObject comboBoxObject = new ComboBoxObject(filePath, (string)campaign["Name"]);
                        selectCampaignComboBox.Items.Add(comboBoxObject);
                    }
                    catch (Exception exception)
                    {
                        Log.Instance.errorLog.Error("Cannot load " + filePath + ". Error: " + exception.Message);
                        continue;
                    }
                }
            }

            if (subdirectoryPaths.Length > 0)
            {
                selectCampaignComboBox.SelectedIndex = 0;
            }
        }

        private void selectCampaignComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _campaign = ((ComboBoxObject)selectCampaignComboBox.SelectedItem).Key;
        }

        private void selectCampaignComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
