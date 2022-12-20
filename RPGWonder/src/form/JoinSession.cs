using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// This class represents a form for joining an existing game session.
    /// </summary>
    public partial class JoinSession : Form
    {
        private string character = "";
        private string ipAddr;
        /// <summary>
        /// Initializes a new instance of the `JoinSession` class.
        /// </summary>
        public JoinSession()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the `Game` object associated with this `JoinSession` instance.
        /// </summary>
        public Client Game
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This method is called when the `JoinSession` form is loaded. It reads the list of available
        /// characters from a JSON file and adds them to the `charactersComboBox` control.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void JoinSession_Load(object sender, EventArgs e)
        {
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\characters";
            if (File.Exists(path + "\\00_Characters.json"))
            {
                JObject data = JObject.Parse(File.ReadAllText(path + "\\00_Characters.json"));
                JArray characters = (JArray)data["characters"];
                foreach (JToken characterTAG in characters)
                {
                    JObject character = JObject.Parse(File.ReadAllText(path + characterTAG.ToString()));
                    ComboBoxObject comboBoxObject = new ComboBoxObject(characterTAG.ToString(), (string)character["Name"]);
                    charactersComboBox.Items.Add(comboBoxObject);
                }
            }
            else
            {
                string message = "00_Characters.json file seems to missing or corrupted.\nCreating a new character should fix this issue.";
                MessageBox.Show(message);
                Close();
            }
        }

        /// <summary>
        /// This method is called when the `JoinGameButton` is clicked. It creates a new `Game` object,
        /// closes the `JoinSession` form, and shows the `Game` form.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void JoinGameButton_Click(object sender, EventArgs e)
        {
            if(character != null)
            {
                ipAddr = ipAddrInput.Text;
                Client gameWindow = new Client(character, ipAddr);
                Close();
                gameWindow.Show();
            }
        }

        private void charactersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            character = ((ComboBoxObject)charactersComboBox.SelectedItem).Key;
        }

    }
}
