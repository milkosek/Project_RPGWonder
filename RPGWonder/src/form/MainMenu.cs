using System;
using System.Windows.Forms;
using RPGWonder.src.form;

namespace RPGWonder
{
    public partial class MainMenu : Form
    {
        public static MainMenu instance;
        public MainMenu()
        {
            InitializeComponent();
            instance = this;
        }

        public Game Game
        {
            get => default;
            set
            {
            }
        }

        public ManageCharacters ManageCharacters
        {
            get => default;
            set
            {
            }
        }

        public ManageCampaigns ManageCampaigns
        {
            get => default;
            set
            {
            }
        }

        public Settings Settings
        {
            get => default;
            set
            {
            }
        }

        public HostSession HostSession
        {
            get => default;
            set
            {
            }
        }

        public JoinSession JoinSession
        {
            get => default;
            set
            {
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void JoinButton_Click(object sender, EventArgs e)
        {     
            JoinSession joinSessionWindow = new JoinSession();
            joinSessionWindow.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settingsWindow = new Settings();
            settingsWindow.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            HostSession hostSessionWindow = new HostSession();
            hostSessionWindow.Show();
        }

        private void CrtCampaignButton_Click(object sender, EventArgs e)
        {
            ManageCampaigns manageCampaignsWindow = new ManageCampaigns();
            manageCampaignsWindow.Show();
        }

        private void CrtCharButton_Click(object sender, EventArgs e)
        {
            ManageCharacters manageCharacterWindow = new ManageCharacters();
            manageCharacterWindow.Show();
        }

        private void DiceDisplay_Click(object sender, EventArgs e)
        {
            DiceDisplay diceDisplay = new DiceDisplay();
            this.Hide();
            diceDisplay.Show();
        }
    }
}
