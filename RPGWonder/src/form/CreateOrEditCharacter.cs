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
        internal int _hp = 0;
        internal int _hp_bonus = 0;

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
        }

        private void CreateOrEditCharacter_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            _character.Level = (int)Common.Instance.Defines["min-level"];
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Races)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject(TAG.Key, (string)Common.Instance.Races[TAG.Key]["name"]);
                raceComboBox.Items.Add(comboBoxObject);
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
            abilitiesTableLayoutPanel.RowCount = Common.Instance.Abilities.Count;
            int i = 0;
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
            {
                NumericUpDown numericUpDown = new NumericUpDown
                {
                    Minimum = (int)Common.Instance.Abilities[TAG.Key]["min-val"],
                    Maximum = (int)Common.Instance.Abilities[TAG.Key]["max-val"],
                    Name = "ability" + TAG.Key + "numericUpDown",
                    Font = new Font("Microsoft Sans Serif", 19),
                    Size = new Size(60, 45),
                    Enabled = false
                };
                if (_editing)
                {
                    numericUpDown.Value = _character.Abilities[TAG.Key];
                    numericUpDown.Enabled = true;
                }
                numericUpDown.ValueChanged += new EventHandler(numericUpDown_ValueChanged);
                Label label = new Label
                {
                    Text = (string)TAG.Value["name"],
                    Name = "ability" + TAG.Key + "label"
                };
                Label proficiency = new Label
                {
                    Text = "+0",
                    Name = "proficiency" + TAG.Key + "label",
                    Font = new Font("Microsoft Sans Serif", 14),
                    Anchor = AnchorStyles.None
                };
                if (_editing)
                {
                    proficiency.Text = _character.Saves[TAG.Key];
                }
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
                {
                    Name = "ability" + TAG.Key + "tableLayoutPanel",
                    RowStyles =
                    {
                        new RowStyle(SizeType.Percent, 75),
                        new RowStyle(SizeType.Percent, 25)
                    },
                    Size = new Size(80, 55)
                };
                tableLayoutPanel.Controls.Add(numericUpDown, 0, 0);
                tableLayoutPanel.Controls.Add(label, 0, 1);
                TableLayoutPanel proficiencyLayoutPanel = new TableLayoutPanel
                {
                    Name = "proficiency" + TAG.Key + "tableLayoutPanel",
                    Size = new Size(80, 55)
                };
                proficiencyLayoutPanel.Controls.Add(proficiency, 0, 0);
                abilitiesTableLayoutPanel.Controls.Add(tableLayoutPanel, 0, i);
                abilitiesTableLayoutPanel.Controls.Add(proficiencyLayoutPanel, 1, i);
                i++;
            }
            foreach (RowStyle style in abilitiesTableLayoutPanel.RowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 60;
            }
            levelNumericUpDown.Minimum = int.Parse((string)Common.Instance.Defines["min-level"]);
            levelNumericUpDown.Maximum = int.Parse((string)Common.Instance.Defines["max-level"]);
            rerollAbilitiesButton.Width = 40;
            rerollAbilitiesButton.Height = 40;
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Skills)
            {
                TableLayoutPanel skillLayoutPanel = new TableLayoutPanel
                {
                    Size = new Size(200, 30)
                };
                Label label = new Label
                {
                    Width = 150,

                    Name = "skill" + TAG.Key + "label",
                    Text = "---"
                };
                skillLayoutPanel.Controls.Add(label);
                skillsTableLayoutPanel.Controls.Add(skillLayoutPanel);
            }
            foreach (RowStyle style in skillsTableLayoutPanel.RowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 30;
            }
            SetMotif();
            saveButton.BackColor = Color.SteelBlue;
            if ((string)Common.Instance.Defines["roll-for-hp"] == "true")
            {
                HPTableLayoutPanel.Visible = true;
            }
            HPNumericUpDown.Maximum = int.MaxValue;
            if (_editing)
            {
                nameTextBox.Text = _character.Name;
                raceComboBox.SelectedIndex = raceComboBox.FindStringExact((string)Common.Instance.Races[_character.Race]["name"]);
                classComboBox.SelectedIndex = classComboBox.FindStringExact((string)Common.Instance.Classes[_character.CharacterClass]["name"]);
                backgroundComboBox.SelectedIndex = backgroundComboBox.FindStringExact((string)Common.Instance.Backgrounds[_character.Background]);
                genderComboBox.SelectedIndex = genderComboBox.FindStringExact((string)Common.Instance.Genders[_character.Gender]);
                levelNumericUpDown.Value = _character.Level;
                alignmentComboBox.SelectedIndex = alignmentComboBox.FindStringExact((string)Common.Instance.Alignments[_character.Alignment]);
                descriptionTextBox.Text = _character.Description;
                equipmentTextBox.Text = _character.Equipment;
                specialTextBox.Text = _character.Specials;
                HPNumericUpDown.Value = _character.CurrentHitPoints;
                proficiencyBonusTextBox.Text = _character.ProficiencyBonus.ToString();
                armorClassTextBox.Text = _character.ArmorClass.ToString();
                speedTextBox.Text = _character.Speed.ToString();
                sizeTextBox.Text = (string)Common.Instance.Sizes[_character.Size];
                hitDiceTextBox.Text = "d" + _character.HitDice.ToString();
                passivePerceptionTextBox.Text = _character.PassiveWisdomPerception.ToString();
                initiativeModifierTextBox.Text = _character.InitiativeModifier.ToString();
                Log.Instance.gameLog.Debug("Editing character: " + _character.Name);
                HPNumericUpDown.Enabled = true;
                UpdateProficiencies();
            }
        }
        private void raceCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleRecalculations();
        }
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleRecalculations();
        }
        private void backgroundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleRecalculations();
        }
        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleRecalculations();
        }
        private void alignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleRecalculations();
        }
        private void levelBox_ValueChanged(object sender, EventArgs e)
        {
            handleRecalculations();
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            _character.Name = nameTextBox.Text;
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
                _character.Abilities.Set(TAG.Key, abilityValue);
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateProficiencies();
            CalculateHPBonus();
            UpdateHP();
            UpdateArmorClass();
            UpdateInitiativeModifier();
            UpdatePassivePerception();
        }

        private void handleRecalculations()
        {
            if (raceComboBox.SelectedItem != null)
            {
                _character.Race = ((ComboBoxObject)raceComboBox.SelectedItem).Key;
                if (rerollAbilitiesButton.Enabled == true || _editing)
                {
                    CalculateHPBonus();
                    UpdateHP();
                }
                UpdateSize();
                UpdateSpeed();
            }
            if (classComboBox.SelectedItem != null)
            {
                _character.CharacterClass = ((ComboBoxObject)classComboBox.SelectedItem).Key;
                UpdateHitDice();
            }
            if (backgroundComboBox.SelectedItem != null)
            {
                _character.Background = ((ComboBoxObject)backgroundComboBox.SelectedItem).Key;
            }
            if (alignmentComboBox.SelectedItem != null)
            {
                _character.Alignment = ((ComboBoxObject)alignmentComboBox.SelectedItem).Key;
            }
            if (genderComboBox.SelectedItem != null)
            {
                _character.Gender = ((ComboBoxObject)genderComboBox.SelectedItem).Key;
            }
            if (levelNumericUpDown.Value >= 1)
            {
                _character.Level = (int)levelNumericUpDown.Value;
                UpdateProficiencyBonus();
                UpdateExperience();
                if (rerollAbilitiesButton.Enabled == true)
                {
                    CalculateHPBonus();
                    CalculateHP();
                    UpdateHP();
                }
            }
            if (raceComboBox.SelectedItem != null && classComboBox.SelectedItem != null)
            {
                if (rerollAbilitiesButton.Enabled == false)
                {
                    rollAbilities();
                    CalculateHPBonus();
                    CalculateHP();
                    UpdateHP();
                }
                rerollAbilitiesButton.Enabled = true;
                foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("ability" + TAG.Key + "numericUpDown", true)[0];
                    numericUpDown.Enabled = true;
                }
            }
        }

        private void UpdatePassivePerception()
        {
            _character.PassiveWisdomPerception = 10 + int.Parse(_character.Saves[(string)Common.Instance.Defines["passive-perception-ability"]]);
            passivePerceptionTextBox.Text = _character.PassiveWisdomPerception.ToString();
        }

        private void UpdateHitDice()
        {
            _character.HitDice = (int)Common.Instance.Classes[_character.CharacterClass]["hit-dice"];
            hitDiceTextBox.Text = "d" + _character.HitDice.ToString();
        }

        private void UpdateArmorClass()
        {
            _character.ArmorClass = 10 + int.Parse(_character.Saves[(string)Common.Instance.Defines["armor-class-ability"]]);
            armorClassTextBox.Text = _character.ArmorClass.ToString();
        }

        private void UpdateHP()
        {
            int hp = _hp + _hp_bonus;
            if (hp < 0) hp = 0;
            HPNumericUpDown.Value = hp;
            _character.CurrentHitPoints = hp;
        }

        private void CalculateHP()
        {
            _hp = 0;
            HPNumericUpDown.Enabled = true;
            int rollStartingFromLevel = 2;
            if ((string)Common.Instance.Defines["using-base-hp"] == "true")
            {
                if ((string)Common.Instance.Defines["using-races-for-base-hp"] == "true")
                {
                    _hp += int.Parse((string)Common.Instance.Races[_character.Race]["hit-points-start"]);
                }
                if ((string)Common.Instance.Defines["using-classes-for-base-hp"] == "true")
                {
                    _hp += int.Parse((string)Common.Instance.Classes[_character.CharacterClass]["hit-points-start"]);
                }
            }
            else
            {
                rollStartingFromLevel = 1;
            }
            for (int i = rollStartingFromLevel; i <= _character.Level; i++)
            {
                if (rollHPComboBox.Text == "avg")
                {
                    if ((string)Common.Instance.Defines["using-races-for-base-hp"] == "true")
                    {
                        _hp += (int)Math.Ceiling(((double)(1 + int.Parse((string)Common.Instance.Races[_character.CharacterClass]["hit-points-level-up"]))) / 2);
                    }
                    if ((string)Common.Instance.Defines["using-classes-for-base-hp"] == "true")
                    {
                        _hp += (int)Math.Ceiling(((double)(1 + int.Parse((string)Common.Instance.Classes[_character.CharacterClass]["hit-points-level-up"]))) / 2);
                    }
                }
                if (rollHPComboBox.Text == "roll")
                {
                    Random rnd = new Random();
                    if ((string)Common.Instance.Defines["using-races-for-base-hp"] == "true")
                    {
                        _hp += rnd.Next(1, int.Parse((string)Common.Instance.Races[_character.CharacterClass]["hit-points-level-up"]));
                    }
                    if ((string)Common.Instance.Defines["using-classes-for-base-hp"] == "true")
                    {
                        _hp += rnd.Next(1, int.Parse((string)Common.Instance.Classes[_character.CharacterClass]["hit-points-level-up"]));
                    }
                }
            }
        }

        private void CalculateHPBonus()
        {
            _hp_bonus = 0;
            foreach (JToken affect in Common.Instance.Defines["abilities-affecting-hp"])
            {
                Dictionary<string, string> dictionary = affect.ToObject<Dictionary<string, string>>();
                string ability = dictionary["ability"];
                string bonusType = dictionary["bonus-type"];
                int mult = int.Parse(dictionary["bonus-multiplication"]);
                if (bonusType == "per level save")
                {
                    _hp_bonus += _character.Level * int.Parse(_character.Saves.Get(ability)) * mult;
                }
                if (bonusType == "once save")
                {
                    _hp_bonus += int.Parse(_character.Saves.Get(ability)) * mult;
                }
                if (bonusType == "per level ability")
                {
                    _hp_bonus += _character.Level * _character.Abilities.Get(ability) * mult;
                }
                if (bonusType == "once ability")
                {
                    _hp_bonus += _character.Abilities.Get(ability) * mult;
                }
            }
            if (Common.Instance.Races[_character.Race].ToObject<Dictionary<string, JToken>>().ContainsKey("hp-bonus"))
            {
                Dictionary<string, string> HPBonus = Common.Instance.Races[_character.Race]["hp-bonus"].ToObject<Dictionary<string, string>>();
                int value = int.Parse(HPBonus["value"]);
                string type = HPBonus["type"];
                if (type == "per level")
                {
                    _hp_bonus += _character.Level * value;
                }
                if (type == "once")
                {
                    _hp_bonus += value;
                }
            }
        }

        private void UpdateExperience()
        {
            _character.Experience = (int)Common.Instance.Levels[_character.Level.ToString()]["exp"];
        }

        private void UpdateSpeed()
        {
            _character.Speed = (int)Common.Instance.Races[_character.Race]["speed"];
            speedTextBox.Text = _character.Speed.ToString();
        }

        private void UpdateInitiativeModifier()
        {
            _character.InitiativeModifier = int.Parse(_character.Saves[(string)Common.Instance.Defines["initiative-ability"]]);
            initiativeModifierTextBox.Text = _character.InitiativeModifier.ToString();
        }

        private void UpdateProficiencyBonus()
        {
            _character.ProficiencyBonus = (int)Common.Instance.Levels[_character.Level.ToString()]["bonus"];
            proficiencyBonusTextBox.Text = _character.ProficiencyBonus.ToString();
        }

        private void UpdateSize()
        {
            _character.Size = (string)Common.Instance.Races[_character.Race]["size"];
            sizeTextBox.Text = (string)Common.Instance.Sizes[_character.Size];
        }

        private void UpdateProficiencies()
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
        private void rerollAbilitiesButton_Click(object sender, EventArgs e)
        {
            rollAbilities();
            CalculateHPBonus();
            UpdateHP();
            handleRecalculations();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Log.Instance.gameLog.Debug("Trying to save: " + _character.Name);
            _character.Description = descriptionTextBox.Text;
            _character.Equipment = equipmentTextBox.Text;
            _character.Specials = specialTextBox.Text;

            if (_character.Name == null || _character.Name == "" || _character.Background == null || _character.Alignment == null ||
                _character.Race == null || _character.CharacterClass == null)
            {
                MessageBox.Show("Please fill all boxes.");
                return;
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
            }
            catch (Exception exception)
            {
                Log.Instance.errorLog.Error("Failed to save character: " + _TAG + " Error: " + exception.Message);
            }
        }

        private void raceComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void genderComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void classComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void backgroundComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void alignmentComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rollHPComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rollHPButton_Click(object sender, EventArgs e)
        {
            CalculateHP();
            UpdateHP();
        }

        private void rollHPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rollHPComboBox.Text == "avg")
            {
                rollHPButton.Enabled = false;
            }
            if (rollHPComboBox.Text == "roll" && rerollAbilitiesButton.Enabled == true)
            {
                rollHPButton.Enabled = true;
            }
        }
    }
}