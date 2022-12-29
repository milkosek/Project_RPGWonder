using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// This class represents a form for creating or editing a character in a role-playing game.
    /// </summary>
    public partial class CreateOrEditCharacter : DefaultForm
    {
        public static CreateOrEditCharacter instance;
        private bool bonusAdded = true;
        private Character CreatedCharacter = new Character();
        /// <summary>
        /// Initializes a new instance of the `CreateOrEditCharacter` class.
        /// </summary>
        public CreateOrEditCharacter()
        {
            InitializeComponent();
            SetMotif();
            instance = this;
        }
        /// <summary>
        /// Populates the form's combo boxes with values from a `Common` instance,
        /// creates `NumericUpDown` objects, and adds them to a `abilitiessTableLayoutPanel`.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CreateOrEditCharacter_Load(object sender, EventArgs e)
        {
            CreatedCharacter.Level = (int)Common.Instance.Defines["min-level"];
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
            /// <summary>
            /// Set the `abilitiesTableLayoutPanel`'s row count to the number of abilities.
            /// </summary>
            AbilitiesTableLayoutPanel.RowCount = Common.Instance.Abilities.Count;
            /// <summary>
            /// Iterate over the abilities and create a `NumericUpDown` and a `TableLayoutPanel` for each ability.
            /// </summary>
            int i = 0;
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
            {
                NumericUpDown numericUpDown = new NumericUpDown();
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                TableLayoutPanel proficiencyLayoutPanel = new TableLayoutPanel();
                Label label = new Label();
                Label proficiency = new Label();
                /// <summary>
                /// Set the `numericUpDown` object's minimum and maximum values based on the ability's min and max values.
                /// </summary>
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
                /// <summary>
                /// Increment the iterator.
                /// </summary>
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
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (CreatedCharacter.Race == null || CreatedCharacter.CharacterClass == null || CreatedCharacter.Name == "" ||
                CreatedCharacter.Background == null || CreatedCharacter.Gender == null || CreatedCharacter.Alignment == null ||
                CreatedCharacter.Level > (int)Common.Instance.Defines["max-level"] ||
                CreatedCharacter.Level < (int)Common.Instance.Defines["min-level"])
            {
                string message = "Please fill all boxes.";
                MessageBox.Show(message);
                return;
            }
            CreatedCharacter.Speed = (int)Common.Instance.Races[CreatedCharacter.Race]["speed"];
            CreatedCharacter.Size = (string)Common.Instance.Races[CreatedCharacter.Race]["size"];
            CreatedCharacter.Experience = (int)Common.Instance.Levels[CreatedCharacter.Level.ToString()]["exp"];
            CreatedCharacter.ProficiencyBonus = (int)Common.Instance.Levels[CreatedCharacter.Level.ToString()]["bonus"];
            CreatedCharacter.PersonalityTraits = personalityTraitsTextBox.Text;
            CreatedCharacter.Ideals = ideaslTextBox.Text;
            CreatedCharacter.Bonds = bondsTextBox.Text;
            CreatedCharacter.Flaws = flawsTextBox.Text;
            swapToPage2();
            rollAbilities();
        }
        private void raceCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatedCharacter.Race = ((ComboBoxObject)raceCcomboBox.SelectedItem).Key;
        }
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatedCharacter.CharacterClass = ((ComboBoxObject)classComboBox.SelectedItem).Key;
        }
        private void backgroundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatedCharacter.Background = ((ComboBoxObject)backgroundComboBox.SelectedItem).Key;
        }
        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatedCharacter.Gender = ((ComboBoxObject)genderComboBox.SelectedItem).Key;
        }
        private void alignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatedCharacter.Alignment = ((ComboBoxObject)alignmentComboBox.SelectedItem).Key;
        }
        private void levelBox_ValueChanged(object sender, EventArgs e)
        {
            CreatedCharacter.Level = (int)levelBox.Value;
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            CreatedCharacter.Name = nameTextBox.Text;
        }
        private void swapToPage2()
        {
            nameLabel.Hide();
            nameTextBox.Hide();
            basicInfoTableLayout.Hide();
            nextButton.Hide();
            characterNameLabel.Text = CreatedCharacter.Name + "\t Lv" + CreatedCharacter.Level + " " +
                Common.Instance.Races[CreatedCharacter.Race]["name"] + " " + Common.Instance.Classes[CreatedCharacter.CharacterClass]["name"];
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
                foreach (JToken TAG in Common.Instance.Races[CreatedCharacter.Race]["increases"])
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
                CreatedCharacter.Abilities.Set(TAG.Key, abilityValue);
            }
        }
        private void handleRecalcProfiencies(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
            {
                NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("ability" + TAG.Key + "numericUpDown", true)[0];
                CreatedCharacter.Abilities.Set(TAG.Key, (int)numericUpDown.Value);
            }
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
                    if (int.Parse(TAG2.Key) <= CreatedCharacter.Abilities[TAG.Key])
                    {
                        maxBonus = (string)TAG2.Value;
                    }
                }
                label.Text = maxBonus;
                CreatedCharacter.Saves[TAG.Key] = maxBonus;
            }
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Skills)
            {
                string ability = (string)Common.Instance.Skills[TAG.Key]["ability"];
                Label label = (Label)Controls.Find("skill" + TAG.Key + "label", true)[0];
                label.Text = CreatedCharacter.Saves.Get(ability) + " " + Common.Instance.Skills[TAG.Key]["name"] + " (" + Common.Instance.Skills[TAG.Key]["ability"] + ")";
                CreatedCharacter.Skills.Set(TAG.Key, CreatedCharacter.Saves.Get(ability));
            }
        }
        private void rerollButton_Click(object sender, EventArgs e)
        {
            rollAbilities();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            CreatedCharacter.ArmorClass = 10 + int.Parse(CreatedCharacter.Saves[(string)Common.Instance.Defines["armor-class-ability"]]);
            CreatedCharacter.InitiativeModifier = int.Parse(CreatedCharacter.Saves[(string)Common.Instance.Defines["initiative-ability"]]);
            CreatedCharacter.PassiveWisdomPerception = 10 + int.Parse(CreatedCharacter.Saves[(string)Common.Instance.Defines["passive-perception-ability"]]);
            CreatedCharacter.SaveToJSON("..\\..\\userData\\" + Properties.Settings.Default.System + "\\characters", CreatedCharacter.Name);
            string message = "Character saved!";
            MessageBox.Show(message);
            Close();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            swapToPage1();
        }
    }
}