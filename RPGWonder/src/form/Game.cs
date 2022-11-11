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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        internal DiceRolls DiceRolls
        {
            get => default;
            set
            {
            }
        }

        internal Campaign Campaign
        {
            get => default;
            set
            {
            }
        }

        internal Connection Connection
        {
            get => default;
            set
            {
            }
        }

        internal VoiceChat VoiceChat
        {
            get => default;
            set
            {
            }
        }
    }
}
