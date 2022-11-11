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
    public partial class JoinSession : Form
    {
        public JoinSession()
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

        private void JoinSession_Load(object sender, EventArgs e)
        {

        }

        private void JoinGameButton_Click(object sender, EventArgs e)
        {
            Game gameWindow = new Game();
            this.Close();
            gameWindow.Show();
        }
    }
}
