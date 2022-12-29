using System;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class ManageCharacters : DefaultForm
    {
        /// <summary>
        /// Constructs a new instance of the `ManageCharacters` class.
        /// </summary>
        public ManageCharacters()
        {
            InitializeComponent();
            SetMotif();
        }

        /// <summary>
        /// Gets or sets the character that is being managed by this form.
        /// </summary>
        internal Character Character
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Handles the click event for the `CrtNewCharacterButton` button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CrtNewCharacterButton_Click(object sender, EventArgs e)
        {
            CreateOrEditCharacter createOrEditCharacter = new CreateOrEditCharacter();
            createOrEditCharacter.Show();
        }
    }
}
