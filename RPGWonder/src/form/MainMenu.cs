using System;
using System.Windows.Forms;
using RPGWonder.src.form;

namespace RPGWonder
{
    /// <summary>
    /// This class represents the main menu form of the RPGWonder application.
    /// </summary>
    public partial class MainMenu : Form
    {
        /// <summary>
        /// The static instance of the `MainMenu` class.
        /// </summary>
        public static MainMenu instance;

        /// <summary>
        /// Initializes a new instance of the `MainMenu` class.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            instance = this;
        }

        /// <summary>
        /// Gets or sets the `Game` object associated with this `MainMenu` instance.
        /// </summary>
        public Client Game
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the `ManageCharacters` object associated with this `MainMenu` instance.
        /// </summary>
        public ManageCharacters ManageCharacters
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the `ManageCampaigns` object associated with this `MainMenu` instance.
        /// </summary>
        public ManageCampaigns ManageCampaigns
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the `Settings` object associated with this `MainMenu` instance.
        /// </summary>
        public Settings Settings
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the `HostSession` object associated with this `MainMenu` instance.
        /// </summary>
        public HostSession HostSession
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the `JoinSession` object associated with this `MainMenu` instance.
        /// </summary>
        public JoinSession JoinSession
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This method is called when the `MainMenu` form is loaded.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method is called when the `JoinButton` is clicked. It creates a new `JoinSession` form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void JoinButton_Click(object sender, EventArgs e)
        {     
            JoinSession joinSessionWindow = new JoinSession();
            joinSessionWindow.Show();
        }

        /// <summary>
        /// This method is called when the `SettingsButton` is clicked. It creates a new `Settings` form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settingsWindow = new Settings();
            settingsWindow.Show();
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
            HostSession hostSessionWindow = new HostSession();
            hostSessionWindow.Show();
        }

        /// <summary>
        /// This method is called when the CrtCampaignButton is clicked. It creates a new ManageCampaigns form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the eve
        private void CrtCampaignButton_Click(object sender, EventArgs e)
        {
            ManageCampaigns manageCampaignsWindow = new ManageCampaigns();
            manageCampaignsWindow.Show();
        }

        /// <summary>
        /// This method is called when the CrtCharButton is clicked. It creates a new ManageCharacters form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the eve
        private void CrtCharButton_Click(object sender, EventArgs e)
        {
            ManageCharacters manageCharacterWindow = new ManageCharacters();
            manageCharacterWindow.Show();
        }

        /// <summary>
        /// This method is called when the TempDiceRollMenu is clicked. It creates a new DiceDisplay form
        /// and shows it to the user.
        /// </summary>
        /// <param name="sender">The object that raised the eve
        private void TempDiceRollMenu_Click(object sender, EventArgs e)
        {
            DiceDisplay manageCharacterWindow = new DiceDisplay();
            manageCharacterWindow.Show();
        }
    }
}
