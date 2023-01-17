using RPGWonder.src.form;
using System;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// Class representing the main menu form of the RPGWonder application.
    /// </summary>
    public partial class MainMenu : DefaultForm
    {
        private static MainMenu _instance = null;
        public static MainMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainMenu();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Initializes a new instance of the `MainMenu` class.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            SetMotif();
            isMain = true;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {    
            if (Common.Instance == null)
            {
                JoinButton.Enabled = false;
                HostButton.Enabled = false;
                ManageCampaignsButton.Enabled = false;
                ManageCharsButton.Enabled = false;
                Log.Instance.errorLog.Error("Error: Path not set correctly");
                MessageBox.Show("The path to game files is not set correctly.\nSet the correct path in Settings.");
            }
            Character character = new Character();
            character.ReadFromJSON("D:\\Archiwum Królewskie\\Studia\\Inzynierka\\RPGWonder\\RPGWonder\\userData\\DnD5e\\characters\\Adam(1).json");
            character.Show();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            JoinSession.Instance.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings.Instance.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            HostSession.Instance.Show();
        }

        private void CrtCampaignButton_Click(object sender, EventArgs e)
        {
            ManageCampaigns.Instance.Show();
        }

        private void CrtCharButton_Click(object sender, EventArgs e)
        {
            ManageCharacters.Instance.Show();
        }
    }
}
