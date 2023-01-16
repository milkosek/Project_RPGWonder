using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// Class representing a form for creating or editing a character.
    /// </summary>
    public partial class CreateOrEditCharacter : DefaultForm
    {
        private static CreateOrEditCharacter _instance = null;
        internal string _path;

        /// <summary>
        /// Gets the instance of the <see cref="CreateOrEditCharacter"/> class.
        /// </summary>
        public static CreateOrEditCharacter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CreateOrEditCharacter();
                }
                return _instance;
            }
        }
        private bool bonusAdded = true;
        private Character _character = new Character();
        internal string _TAG;
        private bool _editing = false;
        /// <summary>
        /// Initializes a new _instance of the `CreateOrEditCharacter` class.
        /// </summary>
        private CreateOrEditCharacter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Public constructor creading an instance of the class for character editing purposes.
        /// <param name="path">The path to the edited character.</param>
        /// </summary>
        public CreateOrEditCharacter(string path)
        {
            InitializeComponent();
            _path = path;
            _character.ReadFromJSON(_path);
            _editing = true;
            nameTextBox.Text = _character.Name;
            raceCcomboBox.Text = (string)Common.Instance.Races[_character.Race]["name"];
            classComboBox.Text = (string)Common.Instance.Classes[_character.CharacterClass]["name"];
            backgroundComboBox.Text = (string)Common.Instance.Backgrounds[_character.Background];
            personalityTraitsTextBox.Text = _character.PersonalityTraits;
            bondsTextBox.Text = _character.Bonds;
            genderComboBox.Text = (string)Common.Instance.Genders[_character.Gender];
            levelBox.Value = _character.Level;
            alignmentComboBox.Text = (string)Common.Instance.Alignments[_character.Alignment];
            ideaslTextBox.Text = _character.Ideals;
            flawsTextBox.Text = _character.Flaws;
            Log.Instance.gameLog.Debug("Editing character: " + _character.Name);
        }

        private void CreateOrEditCharacter_Load(object sender, EventArgs e)
        {
            _character.Level = (int)Common.Instance.Defines["min-level"];
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Races)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject(TAG.Key, (string)Common.Instance.Races[TAG.Key]["name"]);
                raceCcomboBox.Items.Add(comboBoxObject);
            }
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Classes)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject(TAG.Key, (string)Common.Instance.Classes[TAG.Key]["name"]);
                classComboBox.Items.Add(comboBoxObject);
            }
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Backgrounds)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject(TAG.Key, (string)TAG.Value);
                backgroundComboBox.Items.Add(comboBoxObject);
            }
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Genders)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject(TAG.Key, (string)TAG.Value);
                genderComboBox.Items.Add(comboBoxObject);
            }
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Alignments)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject(TAG.Key, (string)TAG.Value);
                alignmentComboBox.Items.Add(comboBoxObject);
            }
            AbilitiesTableLayoutPanel.RowCount = Common.Instance.Abilities.Count;
            int i = 0;
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
            {
                NumericUpDown numericUpDown = new NumericUpDown();
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                TableLayoutPanel proficiencyLayoutPanel = new TableLayoutPanel();
                Label label = new Label();
                Label proficiency = new Label();
                numericUpDown.Minimum = (int)Common.Instance.Abilities[TAG.Key]["min-val"];
                numericUpDown.Maximum = (int)Common.Instance.Abilities[TAG.Key]["max-val"];
                numericUpDown.Name = "ability" + TAG.Key + "numericUpDown";
                numericUpDown.Font = new Font("Microsoft Sans Serif", 19);
                numericUpDown.Size = new Size(60, 45);
                numericUpDown.ValueChanged += new EventHandler(handleRecalcProfiencies);
                label.Text = (string)TAG.Value["name"];
                label.Name = "ability" + TAG.Key + "label";
                proficiency.Text = "+0";
                proficiency.Name = "proficiency" + TAG.Key + "label";
                proficiency.Font = new Font("Microsoft Sans Serif", 14);
                proficiency.Anchor = AnchorStyles.None;
                tableLayoutPanel.Name = "ability" + TAG.Key + "tableLayoutPanel";
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
                tableLayoutPanel.Controls.Add(numericUpDown, 0, 0);
                tableLayoutPanel.Controls.Add(label, 0, 1);
                tableLayoutPanel.Size = new Size(80, 55);
                proficiencyLayoutPanel.Name = "proficiency" + TAG.Key + "tableLayoutPanel";
                proficiencyLayoutPanel.Controls.Add(proficiency, 0, 0);
                proficiencyLayoutPanel.Size = new Size(80, 55);
                AbilitiesTableLayoutPanel.Controls.Add(tableLayoutPanel, 0, i);
                AbilitiesTableLayoutPanel.Controls.Add(proficiencyLayoutPanel, 1, i);
                i++;
            }
            foreach (RowStyle style in AbilitiesTableLayoutPanel.RowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 60;
            }
            levelBox.Minimum = int.Parse((string)Common.Instance.Defines["min-level"]);
            levelBox.Maximum = int.Parse((string)Common.Instance.Defines["max-level"]);
            rerollButton.Width = 50;
            rerollButton.Height = 50;
            skillsTableLayoutPanel.Width = 250;
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Skills)
            {
                TableLayoutPanel skillLayoutPanel = new TableLayoutPanel();
                skillLayoutPanel.Size = new Size(200, 30);
                Label label = new Label();
                label.Width = 150;
                label.Name = "skill" + TAG.Key + "label";
                label.Text = "---";
                skillLayoutPanel.Controls.Add(label);
                skillsTableLayoutPanel.Controls.Add(skillLayoutPanel);
            }
            foreach (RowStyle style in skillsTableLayoutPanel.RowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 30;
            }
            SetMotif();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (_character.Race == null || _character.CharacterClass == null || _character.Name == "" ||
                _character.Background == null || _character.Gender == null || _character.Alignment == null ||
                _character.Level > (int)Common.Instance.Defines["max-level"] ||
                _character.Level < (int)Common.Instance.Defines["min-level"])
            {
                string message = "Please fill all boxes.";
                MessageBox.Show(message);
                return;
            }
            _character.Speed = (int)Common.Instance.Races[_character.Race]["speed"];
            _character.Size = (string)Common.Instance.Races[_character.Race]["size"];
            _character.Experience = (int)Common.Instance.Levels[_character.Level.ToString()]["exp"];
            _character.ProficiencyBonus = (int)Common.Instance.Levels[_character.Level.ToString()]["bonus"];
            _character.PersonalityTraits = personalityTraitsTextBox.Text;
            _character.Ideals = ideaslTextBox.Text;
            _character.Bonds = bondsTextBox.Text;
            _character.Flaws = flawsTextBox.Text;
            swapToPage2();
            if (!_editing)
            {
                rollAbilities();
            }
            else
            {
                foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
                {
                    Debug.WriteLine(_character.Abilities.Get(TAG.Key));
                    NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("ability" + TAG.Key + "numericUpDown", true)[0];
                    numericUpDown.Value = _character.Abilities.Get(TAG.Key);
                }
            }
        }
        private void raceCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Race = ((ComboBoxObject)raceCcomboBox.SelectedItem).Key;
        }
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.CharacterClass = ((ComboBoxObject)classComboBox.SelectedItem).Key;
        }
        private void backgroundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Background = ((ComboBoxObject)backgroundComboBox.SelectedItem).Key;
        }
        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Gender = ((ComboBoxObject)genderComboBox.SelectedItem).Key;
        }
        private void alignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _character.Alignment = ((ComboBoxObject)alignmentComboBox.SelectedItem).Key;
        }
        private void levelBox_ValueChanged(object sender, EventArgs e)
        {
            _character.Level = (int)levelBox.Value;
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            _character.Name = nameTextBox.Text;
        }
        private void swapToPage2()
        {
            nameLabel.Hide();
            nameTextBox.Hide();
            basicInfoTableLayout.Hide();
            nextButton.Hide();
            characterNameLabel.Text = _character.Name + "\t Lv" + _character.Level + " " +
                Common.Instance.Races[_character.Race]["name"] + " " + Common.Instance.Classes[_character.CharacterClass]["name"];
            characterNameLabel.Show();
            AbilitiesTableLayoutPanel.Show();
            rerollButton.Show();
            skillsTableLayoutPanel.Show();
            saveButton.Show();
            backButton.Show();
        }
        private void swapToPage1()
        {
            nameLabel.Show();
            nameTextBox.Show();
            basicInfoTableLayout.Show();
            nextButton.Show();
            characterNameLabel.Hide();
            AbilitiesTableLayoutPanel.Hide();
            rerollButton.Hide();
            skillsTableLayoutPanel.Hide();
            saveButton.Hide();
            backButton.Hide();
        }
        private void rollAbilities()
        {
            if (bonusAdded)
            {
                foreach (JToken TAG in Common.Instance.Races[_character.Race]["increases"])
                {
                    string ability = (string)TAG["ability"];
                    int bonus = (int)TAG["bonus"];
                    NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("ability" + ability + "numericUpDown", true)[0];
                    numericUpDown.Minimum += bonus;
                    bonusAdded = false;
                }
            }
            DiceRolls diceRolls = new DiceRolls();
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
            {
                diceRolls.Clear();
                NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("ability" + TAG.Key + "numericUpDown", true)[0];
                for (int j = 0; j < int.Parse((string)Common.Instance.Defines["ability-dice-rolled"]); j++)
                {
                    diceRolls.AddDie(int.Parse((string)Common.Instance.Defines["ability-dice-faces"]));
                }
                List<int> rolls = diceRolls.Roll()[int.Parse((string)Common.Instance.Defines["ability-dice-faces"])];
                rolls.Sort();
                for (int j = 0; j < int.Parse((string)Common.Instance.Defines["ability-dice-ignored"]); j++)
                {
                    rolls.RemoveAt(0);
                }
                int abilityValue = rolls.Sum() + (int)(numericUpDown.Minimum) - int.Parse((string)Common.Instance.Defines["ability-dice-rolled"]);
                if (abilityValue < (int)(numericUpDown.Minimum)) abilityValue = (int)(numericUpDown.Minimum);
                if (abilityValue > (int)(numericUpDown.Maximum)) abilityValue = (int)(numericUpDown.Maximum);
                numericUpDown.Value = abilityValue;
            }
        }
        private void handleRecalcProfiencies(object sender, EventArgs e)
        {
            updateProficiencies();
        }
        private void updateProficiencies()
        {
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
            {
                string maxBonus = "+0";
                Label label = (Label)Controls.Find("proficiency" + TAG.Key + "label", true)[0];
                foreach (KeyValuePair<string, JToken> TAG2 in Common.Instance.Proficiencies)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("ability" + TAG.Key + "numericUpDown", true)[0];
                    if (int.Parse(TAG2.Key) <= numericUpDown.Value)
                    {
                        maxBonus = (string)TAG2.Value;
                    }
                }
                label.Text = maxBonus;
                _character.Saves[TAG.Key] = maxBonus;
            }
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Skills)
            {
                string ability = (string)Common.Instance.Skills[TAG.Key]["ability"];
                Label label = (Label)Controls.Find("skill" + TAG.Key + "label", true)[0];
                label.Text = _character.Saves.Get(ability) + " " + Common.Instance.Skills[TAG.Key]["name"] + " (" + Common.Instance.Skills[TAG.Key]["ability"] + ")";
                
            }
        }
        private void rerollButton_Click(object sender, EventArgs e)
        {
            rollAbilities();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Log.Instance.gameLog.Debug("Trying to save: " + _character.Name);
            _character.ArmorClass = 10 + int.Parse(_character.Saves[(string)Common.Instance.Defines["armor-class-ability"]]);
            _character.InitiativeModifier = int.Parse(_character.Saves[(string)Common.Instance.Defines["initiative-ability"]]);
            _character.PassiveWisdomPerception = 10 + int.Parse(_character.Saves[(string)Common.Instance.Defines["passive-perception-ability"]]);
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
            {
                NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("ability" + TAG.Key + "numericUpDown", true)[0];
                _character.Abilities.Set(TAG.Key, (int)numericUpDown.Value);
            }
            if (!_editing)
            {
                _TAG = _character.Name;
                string newTAG = _TAG;
                int counter = 1;
                while (File.Exists(Common.Instance.CharactersPath + "\\" + newTAG + ".json"))
                {
                    Log.Instance.errorLog.Error("Character with TAG " + newTAG + "already exists!");
                    newTAG = $"{_TAG}({counter})";
                    counter++;
                }
                _TAG = newTAG;
            }
            else
            {
                _TAG = Path.GetFileNameWithoutExtension(_path);
            }

            try
            {
                _character.SaveToJSON(Common.Instance.CharactersPath, _TAG);
                Log.Instance.gameLog.Debug("Saved character: " + _TAG);
                MessageBox.Show("Character saved!");
                ManageCharacters.Instance.Show();
                ManageCharacters.Instance.swapToPage2();
                ManageCharacters.Instance.Reload();
                Hide();
                swapToPage1();
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Failed to save character: " + _TAG + " Error: " + exception.Message);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            swapToPage1();
        }
    }
}