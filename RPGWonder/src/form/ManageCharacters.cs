using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class ManageCharacters : DefaultForm
    {
        private static ManageCharacters _instance = null;
        public static ManageCharacters Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManageCharacters();
                }
                return _instance;
            }
        }

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

        /// <summary>
        /// Swaps to the second page of the manager (the proper management).
        /// </summary>
        public void swapToPage2()
        {
            CrtNewCharacterButton.Hide();
            LoadCharacterButton.Hide();
            createCharacterButton.Show();
            editCharacterButton.Show();
            deleteCharacterButton.Show();
            manageCharactersListBox.Show();
        }

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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Reload();
        }

        /// <summary>
        /// Reloads the list of characters from the ./userdata/characters directory.
        /// </summary>
        public void Reload()
        {
            Log.Instance.gameLog.Debug("ManageCharacters: Reloading...");
            manageCharactersListBox.Items.Clear();
            string path = Properties.Settings.Default.Path + "userData\\" + Properties.Settings.Default.System + "\\characters";
            string[] characters;
            if (Directory.Exists(path))
            {
                characters = Directory.GetFiles(path);
            }
            else
            {
                Log.Instance.errorLog.Error("Directory " + path + " not found!");
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
                catch (Exception exception)
                {
                    Log.Instance.errorLog.Error("Cannot load " + character + ". Error: " + exception.Message);
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

        private void createCharacterButton_Click(object sender, EventArgs e)
        {
            CreateOrEditCharacter.Instance.Show();
            Close();
        }
    }
}
