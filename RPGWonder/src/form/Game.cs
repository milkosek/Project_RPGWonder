using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// This class represents the main game window.
    /// </summary>
    public partial class Game : Form
    {
        /// <summary>
        /// Initializes a new instance of the `Game` class.
        /// </summary>
        public Game()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the `DiceRolls` object associated with this `Game` instance.
        /// </summary>
        internal DiceRolls DiceRolls
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the `Campaign` object associated with this `Game` instance.
        /// </summary>
        internal Campaign Campaign
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the `Connection` object associated with this `Game` instance.
        /// </summary>
        internal Connection Connection
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the `VoiceChat` object associated with this `Game` instance.
        /// </summary>
        internal VoiceChat VoiceChat
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This method is called when the `Game` form is loaded. It hides the main menu.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Game_Load(object sender, EventArgs e)
        {
            MainMenu.instance.Hide();
        }
    }
}
