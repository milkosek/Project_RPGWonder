using System;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
