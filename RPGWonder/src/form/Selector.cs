using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace RPGWonder.src.form
{
    public partial class Selector : DefaultForm
    {
        private Host host;
        private string SelectedMap;
        private string campaignFolder;

        private static Selector instance = null;
        public static Selector Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Selector();
                }
                return instance;
            }
        }

        public Selector()
        {
            InitializeComponent();
            SetMotif();

            this.TopMost = true;
        }


        public void Selector_Init(Host host, string campaign)
        {
            this.host = host;

            selectCampaignComboBox.Items.Clear();
            campaignFolder = campaign;

            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\campaigns\\" + campaignFolder + "\\maps";

            string[] filePaths = Directory.GetFiles(path, "*.json");

            foreach (string filePath in filePaths)
            {
                JObject map = JObject.Parse(File.ReadAllText(filePath));
                ComboBoxObject comboBoxObject = new ComboBoxObject(map["Id"].ToString(), (string)map["Name"]);
                selectCampaignComboBox.Items.Add(comboBoxObject);
            }

            if (filePaths.Length > 0)
            {
                selectCampaignComboBox.SelectedIndex = 0;
            }
        }

        private void Selector_Load(object sender, EventArgs e)
        {
        }

        private void selectCampaignComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMap = ((ComboBoxObject)selectCampaignComboBox.SelectedItem).Key;
            Debug.WriteLine(SelectedMap);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            host.LoadMap(Int32.Parse(SelectedMap));
            Close();
        }

        protected override void Dispose(bool disposing)
        {
            instance = null;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
