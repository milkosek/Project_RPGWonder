using RPGWonder.src.form;
using System;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// This class represents the main menu form of the RPGWonder application.
    /// </summary>
    public partial class MainMenu : DefaultForm
    {
        private static MainMenu instance = null;
        public static MainMenu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainMenu();
                }
                return instance;
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

        /// <summary>
        /// This method is called when the `MainMenu` form is loaded.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MainMenu_Load(object sender, EventArgs e)
        {    
            if (Common.Instance == null)
            {
                JoinButton.Enabled = false;
                HostButton.Enabled = false;
                ManageCampaignsButton.Enabled = false;
                ManageCharsButton.Enabled = false;
                MessageBox.Show("The path to game files is not set correctly.\nSet the correct path in Settings.");
            }

            Campaign campaign = new Campaign();
            campaign.ReadFromJSON("D:/Archiwum Królewskie/Studia/Inzynierka/RPGWonder/RPGWonder/userData/DnD5e/campaigns/dau/dau.json");
        }

        /// <summary>
        /// This method is called when the `JoinButton` is clicked. It creates a new `JoinSession` form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void JoinButton_Click(object sender, EventArgs e)
        {
            JoinSession.Instance.Show();
        }

        /// <summary>
        /// This method is called when the `SettingsButton` is clicked. It creates a new `Settings` form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings.Instance.Show();
        }

        /// <summary>
        /// This method is called when the ExitButton is clicked. It exits the application.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method is called when the HostButton is clicked. It creates a new HostSession form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void HostButton_Click(object sender, EventArgs e)
        {
            HostSession.Instance.Show();
        }

        /// <summary>
        /// This method is called when the CrtCampaignButton is clicked. It creates a new ManageCampaigns form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the eve
        private void CrtCampaignButton_Click(object sender, EventArgs e)
        {
            ManageCampaigns.Instance.Show();
        }

        /// <summary>
        /// This method is called when the CrtCharButton is clicked. It creates a new ManageCharacters form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the eve
        private void CrtCharButton_Click(object sender, EventArgs e)
        {
            ManageCharacters.Instance.Show();
        }
    }
}
