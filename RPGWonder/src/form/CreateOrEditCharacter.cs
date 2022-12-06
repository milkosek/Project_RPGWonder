using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RPGWonder
{
    /// <summary>
    /// This class represents a form for creating or editing a character in a role-playing game.
    /// </summary>
    public partial class CreateOrEditCharacter : Form
    {
        public static CreateOrEditCharacter instance;
        private string race = "";
        private string classname = "";
        private string background = "";
        private string gender = "";
        private string alignment = "";
        private int level = 1;
        private string name = "";
        private bool bonusAdded = true;
        private Character CreatedCharacter = new Character();
        /// <summary>
        /// Initializes a new instance of the `CreateOrEditCharacter` class.
        /// </summary>
        public CreateOrEditCharacter()
        {
            InitializeComponent();
            instance = this;
        }
        /// <summary>
        /// Populates the form's combo boxes with values from a `Common` instance,
        /// creates `NumericUpDown` objects, and adds them to a `statsTableLayoutPanel`.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CreateOrEditCharacter_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Races)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject(TAG.Key, (string)Common.Instance.Races[TAG.Key]["name"]);
                raceCcomboBox.Items.Add(comboBoxObject);
            }
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Classes)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject(TAG.Key, (string)TAG.Value);
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
            /// Set the `statsTableLayoutPanel`'s row count to the number of stats.
            /// </summary>
            statsTableLayoutPanel.RowCount = Common.Instance.Stats.Count;
            /// <summary>
            /// Iterate over the stats and create a `NumericUpDown` and a `TableLayoutPanel` for each stat.
            /// </summary>
            int i = 0;
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Stats)
            {
                NumericUpDown numericUpDown = new NumericUpDown();
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                TableLayoutPanel proficiencyLayoutPanel = new TableLayoutPanel();
                Label label = new Label();
                Label proficiency = new Label();
                /// <summary>
                /// Set the `numericUpDown` object's minimum and maximum values based on the stat's min and max values.
                /// </summary>
                numericUpDown.Minimum = (int)Common.Instance.Stats[TAG.Key]["min-val"];
                numericUpDown.Maximum = (int)Common.Instance.Stats[TAG.Key]["max-val"];
                numericUpDown.Name = "stat" + TAG.Key + "numericUpDown";
                numericUpDown.Font = new Font("Microsoft Sans Serif", 19);
                numericUpDown.Size = new Size(60, 45);
                numericUpDown.ValueChanged += new EventHandler(handleRecalcProfiencies);
                label.Text = (string)TAG.Value["name"];
                label.Name = "stat" + TAG.Key + "label";
                proficiency.Text = "+0";
                proficiency.Name = "proficiency" + TAG.Key + "label";
                proficiency.Font = new Font("Microsoft Sans Serif", 14);
                proficiency.Anchor = AnchorStyles.None;
                tableLayoutPanel.Name = "stat" + TAG.Key + "tableLayoutPanel";
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
                tableLayoutPanel.Controls.Add(numericUpDown, 0, 0);
                tableLayoutPanel.Controls.Add(label, 0, 1);
                tableLayoutPanel.Size = new Size(80, 55);
                proficiencyLayoutPanel.Name = "proficiency" + TAG.Key + "tableLayoutPanel";
                proficiencyLayoutPanel.Controls.Add(proficiency, 0, 0);
                proficiencyLayoutPanel.Size = new Size(80, 55);
                statsTableLayoutPanel.Controls.Add(tableLayoutPanel, 0, i);
                statsTableLayoutPanel.Controls.Add(proficiencyLayoutPanel, 1, i);
                /// <summary>
                /// Increment the iterator.
                /// </summary>
                i++;
            }
            foreach (RowStyle style in statsTableLayoutPanel.RowStyles)
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
            if (race == "" || classname == "" || name == "" || background == "" ||
                gender == "" || alignment == "" || 
                level > (int)Common.Instance.Defines["max-level"] || level < (int)Common.Instance.Defines["min-level"])
            {
                string message = "Please fill all boxes.";
                MessageBox.Show(message);
                return;
            }
            CreatedCharacter.Race = race;
            CreatedCharacter.Speed = (int)Common.Instance.Races[CreatedCharacter.Race]["speed"];
            CreatedCharacter.Size = (string)Common.Instance.Races[CreatedCharacter.Race]["size"];
            CreatedCharacter.CharacterClass = classname;
            CreatedCharacter.Name = name;
            CreatedCharacter.Background = background;
            CreatedCharacter.Gender = gender;
            CreatedCharacter.Level = level;
            CreatedCharacter.Experience = (int)Common.Instance.Levels[CreatedCharacter.Level.ToString()]["exp"];
            CreatedCharacter.ProficiencyBonus = (int)Common.Instance.Levels[CreatedCharacter.Level.ToString()]["bonus"];
            CreatedCharacter.Alignment = alignment;
            CreatedCharacter.PersonalityTraits = personalityTraitsTextBox.Text;
            CreatedCharacter.Ideals = ideaslTextBox.Text;
            CreatedCharacter.Bonds = bondsTextBox.Text;
            CreatedCharacter.Flaws = flawsTextBox.Text;
            swapToPage2();
            rollStats();
        }
        private void raceCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            race = ((ComboBoxObject)raceCcomboBox.SelectedItem).Key; 
        }
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            classname = ((ComboBoxObject)classComboBox.SelectedItem).Key;
        }
        private void backgroundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            background = ((ComboBoxObject)backgroundComboBox.SelectedItem).Key;
        }
        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = ((ComboBoxObject)genderComboBox.SelectedItem).Key;
        }
        private void alignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alignment = ((ComboBoxObject)alignmentComboBox.SelectedItem).Key;
        }
        private void levelBox_ValueChanged(object sender, EventArgs e)
        {
            level = (int)levelBox.Value;
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
        }
        private void swapToPage2()
        {
            nameLabel.Hide();
            nameTextBox.Hide();
            basicInfoTableLayout.Hide();
            nextButton.Hide();
            characterNameLabel.Text = CreatedCharacter.Name + "\t Lv" + CreatedCharacter.Level + " " +
                Common.Instance.Races[CreatedCharacter.Race]["name"] + " " + Common.Instance.Classes[CreatedCharacter.CharacterClass];
            characterNameLabel.Show();
            statsTableLayoutPanel.Show();
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
            statsTableLayoutPanel.Hide();
            rerollButton.Hide();
            skillsTableLayoutPanel.Hide();
            saveButton.Hide();
            backButton.Hide();
        }
        private void rollStats()
        {
            if (bonusAdded)
            {
                foreach (KeyValuePair<string, JToken> TAG in Common.Instance.RacialIncreases)
                {
                    if ((string)Common.Instance.RacialIncreases[TAG.Key]["race"] == CreatedCharacter.Race)
                    {
                        string stat = (string)Common.Instance.RacialIncreases[TAG.Key]["stat"];
                        int bonus = (int)Common.Instance.RacialIncreases[TAG.Key]["bonus"];
                        NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("stat" + stat + "numericUpDown", true)[0];
                        numericUpDown.Minimum += bonus;
                        bonusAdded = false;
                    }
                }
            }
            DiceRolls diceRolls = new DiceRolls();
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Stats)
            {
                diceRolls.Clear();
                NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("stat" + TAG.Key + "numericUpDown", true)[0];
                for (int j = 0; j < int.Parse((string)Common.Instance.Defines["stat-dice-rolled"]); j++)
                {
                    diceRolls.AddDie(int.Parse((string)Common.Instance.Defines["stat-dice-faces"]));
                }
                List<int> rolls = diceRolls.Roll()[int.Parse((string)Common.Instance.Defines["stat-dice-faces"])];
                rolls.Sort();
                for (int j = 0; j < int.Parse((string)Common.Instance.Defines["stat-dice-ignored"]); j++)
                {
                    rolls.RemoveAt(0);
                }
                int statValue = rolls.Sum() + (int)(numericUpDown.Minimum) - int.Parse((string)Common.Instance.Defines["stat-dice-rolled"]);
                if (statValue < (int)(numericUpDown.Minimum)) statValue = (int)(numericUpDown.Minimum);
                if (statValue > (int)(numericUpDown.Maximum)) statValue = (int)(numericUpDown.Maximum);
                numericUpDown.Value = statValue;
                CreatedCharacter.Stats.Set(TAG.Key, statValue);
            }
        }
        private void handleRecalcProfiencies(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Stats)
            {
                NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("stat" + TAG.Key + "numericUpDown", true)[0];
                CreatedCharacter.Stats.Set(TAG.Key, (int)numericUpDown.Value);
            }
            updateProficiencies();
        }
        private void updateProficiencies()
        {
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Stats)
            {
                string maxBonus = "+0";
                Label label = (Label)Controls.Find("proficiency" + TAG.Key + "label", true)[0];
                foreach (KeyValuePair<string, JToken> TAG2 in Common.Instance.Proficiencies)
                {
                    if (int.Parse(TAG2.Key) <= CreatedCharacter.Stats[TAG.Key])
                    {
                        maxBonus = (string)TAG2.Value;
                    }
                }
                label.Text = maxBonus;
                CreatedCharacter.Saves[TAG.Key] = maxBonus;
            }
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Skills)
            {
                string stat = (string)Common.Instance.Skills[TAG.Key]["stat"];
                Label label = (Label)Controls.Find("skill" + TAG.Key + "label", true)[0];
                label.Text = CreatedCharacter.Saves.Get(stat) + " " + Common.Instance.Skills[TAG.Key]["name"] + " (" + Common.Instance.Skills[TAG.Key]["stat"] + ")";
                CreatedCharacter.Skills.Set(TAG.Key, CreatedCharacter.Saves.Get(stat));
            }
        }
        private void rerollButton_Click(object sender, EventArgs e)
        {
            rollStats();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            CreatedCharacter.ArmorClass = 10 + int.Parse(CreatedCharacter.Saves[(string)Common.Instance.Defines["armor-class-stat"]]);
            CreatedCharacter.InitiativeModifier = int.Parse(CreatedCharacter.Saves[(string)Common.Instance.Defines["initiative-stat"]]);
            CreatedCharacter.PassiveWisdomPerception = 10 + int.Parse(CreatedCharacter.Saves[(string)Common.Instance.Defines["passive-perception-stat"]]);
            CreatedCharacter.SaveToJSON("..\\..\\userData\\" + Properties.Settings.Default.System + "\\characters");
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