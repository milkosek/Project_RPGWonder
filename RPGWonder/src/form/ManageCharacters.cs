using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class ManageCharacters : DefaultForm
    {
        private static ManageCharacters instance = null;
        public static ManageCharacters Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageCharacters();
                }
                return instance;
            }
        }
        /// <summary>
        /// Constructs a new instance of the `ManageCharacters` class.
        /// </summary>
        private ManageCharacters()
        {
            InitializeComponent();
            SetMotif();
            CrtNewCharacterButton.BackColor = Color.SeaGreen;
            LoadCharacterButton.BackColor = Color.SteelBlue;
            editCharacterButton.BackColor = Color.SteelBlue;
            deleteCharacterButton.BackColor = Color.IndianRed;
            createCharacterButton.BackColor = Color.SeaGreen;
        }

        public void swapToPage2()
        {
            CrtNewCharacterButton.Hide();
            LoadCharacterButton.Hide();
            createCharacterButton.Show();
            editCharacterButton.Show();
            deleteCharacterButton.Show();
            manageCharactersListBox.Show();
        }

        /// <summary>
        /// Handles the click event for the `CrtNewCharacterButton` button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CrtNewCharacterButton_Click(object sender, EventArgs e)
        {
            CreateOrEditCharacter.Instance.Show();
            Close();
        }

        private void EditCharacterButton_Click(object sender, EventArgs e)
        {
            swapToPage2();
        }

        private void ManageCharacters_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            manageCharactersListBox.Items.Clear();
            string path = Properties.Settings.Default.Path + "userData\\" + Properties.Settings.Default.System + "\\characters";
            string[] characters;
            if (Directory.Exists(path))
            {
                characters = Directory.GetFiles(path);
            }
            else
            {
                characters = new string[0];
            }
            foreach (string character in characters)
            {
                try
                {
                    string jsonString = File.ReadAllText(character);
                    JObject json = JObject.Parse(jsonString);
                    ComboBoxObject comboBoxObject = new ComboBoxObject
                    {
                        Key = character,
                        Value = (string)json["Name"]
                    };
                    manageCharactersListBox.Items.Add(comboBoxObject);
                }
                catch (Exception)
                {
                    Log.Instance.errorLog.Error("Character file " + character + " couldn't be read!");
                }
            }
        }

        private void manageCharactersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (manageCharactersListBox.SelectedItem != null)
            {
                editCharacterButton.Enabled = true;
                deleteCharacterButton.Enabled = true;
            }
        }

        private void editCharacterButton_Click(object sender, EventArgs e)
        {
            CreateOrEditCharacter createOrEditCharacter = new CreateOrEditCharacter(((ComboBoxObject)manageCharactersListBox.SelectedItem).Key);
            createOrEditCharacter.Show();
            Close();
        }

        private void deleteCharacterButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                File.Delete(((ComboBoxObject)manageCharactersListBox.SelectedItem).Key);
                Log.Instance.gameLog.Debug("Deleted: " + ((ComboBoxObject)manageCharactersListBox.SelectedItem).Key);
                Reload();
            }
        }

        protected override void Dispose(bool disposing)
        {
            instance = null;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void createCharacterButton_Click(object sender, EventArgs e)
        {
            CreateOrEditCharacter.Instance.Show();
            Close();
        }
    }
}
