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
    public partial class ManageCharacters : Form
    {
        public ManageCharacters()
        {
            InitializeComponent();
        }

        internal Character Character
        {
            get => default;
            set
            {
            }
        }

        private void CrtNewCharacterButton_Click(object sender, EventArgs e)
        {
            CreateOrEditCharacter createOrEditCharacter = new CreateOrEditCharacter();
            createOrEditCharacter.Show();
        }
    }
}
