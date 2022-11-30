using Newtonsoft.Json;
using RPGWonder.src.common;
using RPGWonder.src.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPGWonder
{
    public partial class CreateOrEditCharacter : Form
    {
        public static CreateOrEditCharacter instance;
        private int race = -1;
        private int classname = -1;
        private int background = -1;
        private int gender = -1;
        private int alignment = -1;
        private int level = 1;
        private string name = "";
        private bool bonusAdded = true;
        private Character CreatedCharacter = new Character();

        public CreateOrEditCharacter()
        {
            InitializeComponent();
            instance = this;
        }
        private void CreateOrEditCharacter_Load(object sender, EventArgs e)
        {
            initCharacter(CreatedCharacter);
            for (int i = 0; i < Common.Instance.Races.Count; i++)
            {
                raceCcomboBox.Items.Add(Common.Instance.Races.Values.ToList()[i]);
            }
            for (int i = 0; i < Common.Instance.Classnames.Count; i++)
            {
                classComboBox.Items.Add(Common.Instance.Classnames.Values.ToList()[i]);
            }
            for (int i = 0; i < Common.Instance.Backgrounds.Count; i++)
            {
                backgroundComboBox.Items.Add(Common.Instance.Backgrounds.Values.ToList()[i]);
            }
            for (int i = 0; i < Common.Instance.Genders.Count; i++)
            {
                genderComboBox.Items.Add(Common.Instance.Genders.Values.ToList()[i]);
            }
            for (int i = 0; i < Common.Instance.Alignments.Count; i++)
            {
                alignmentComboBox.Items.Add(Common.Instance.Alignments.Values.ToList()[i]);
            }
            statsTableLayoutPanel.RowCount = Common.Instance.Stats.Count;
            for (int i = 0; i < Common.Instance.Stats.Count; i++)
            {
                string TAG = Common.Instance.Stats.Keys.ToList()[i];
                NumericUpDown numericUpDown = new NumericUpDown();
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                TableLayoutPanel proficiencyLayoutPanel = new TableLayoutPanel();
                Label label = new Label();
                Label proficiency = new Label();
                numericUpDown.Minimum = int.Parse(Common.Instance.Stats[TAG]["min-val"]);
                numericUpDown.Maximum = int.Parse(Common.Instance.Stats[TAG]["max-val"]);
                numericUpDown.Name = "stat" + Common.Instance.Stats.Keys.ToList()[i] + "numericUpDown";
                numericUpDown.Font = new Font("Microsoft Sans Serif", 19);
                numericUpDown.Size = new Size(60, 45);
                numericUpDown.ValueChanged += new EventHandler(handleRecalcProfiencies);
                label.Text = Common.Instance.Stats[TAG]["name"];
                label.Name = "stat" + Common.Instance.Stats.Keys.ToList()[i] + "label";
                proficiency.Text = "+0";
                proficiency.Name = "proficiency" + Common.Instance.Stats.Keys.ToList()[i] + "label";
                proficiency.Font = new Font("Microsoft Sans Serif", 14);
                proficiency.Anchor = AnchorStyles.None;
                tableLayoutPanel.Name = "stat" + Common.Instance.Stats.Keys.ToList()[i] + "tableLayoutPanel";
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
                tableLayoutPanel.Controls.Add(numericUpDown, 0, 0);
                tableLayoutPanel.Controls.Add(label, 0, 1);
                tableLayoutPanel.Size = new Size(80, 55);
                proficiencyLayoutPanel.Name = "proficiency" + Common.Instance.Stats.Keys.ToList()[i] + "tableLayoutPanel";
                proficiencyLayoutPanel.Controls.Add(proficiency, 0, 0);
                proficiencyLayoutPanel.Size = new Size(80, 55);
                statsTableLayoutPanel.Controls.Add(tableLayoutPanel, 0, i);
                statsTableLayoutPanel.Controls.Add(proficiencyLayoutPanel, 1, i);
            }
            foreach (RowStyle style in statsTableLayoutPanel.RowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 60;
            }
            levelBox.Minimum = int.Parse(Common.Instance.Defines["min-level"]);
            levelBox.Maximum = int.Parse(Common.Instance.Defines["max-level"]);
            rerollButton.Width = 50;
            rerollButton.Height = 50;
            skillsTableLayoutPanel.Width = 250;
            for (int i = 0; i < Common.Instance.Skills.Count; i++)
            {
                TableLayoutPanel skillLayoutPanel = new TableLayoutPanel();
                skillLayoutPanel.Size = new Size(200, 30);
                string TAG = Common.Instance.Skills.Keys.ToList()[i];
                Label label = new Label();
                label.Width = 150;
                label.Name = "skill" + TAG + "label";
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

        private void initCharacter(Character createdCharacter)
        {
            for (int i = 0; i < Common.Instance.Stats.Count; i++)
            {
                string TAG = Common.Instance.Stats.Keys.ToList()[0];
                createdCharacter.Stats.Set(TAG, 0);
            }
            for (int i = 0; i < Common.Instance.Skills.Count; i++)
            {
                string TAG = Common.Instance.Skills.Keys.ToList()[0];
                createdCharacter.Skills.Set(TAG, "+0");
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (race == -1 || classname == -1 || name == "" || background == -1 ||
                gender == -1 || alignment == -1 || level < 1 || level > 20)
            {
                string message = "Please fill all boxes.";
                MessageBox.Show(message);
                return;
            }
            CreatedCharacter.Race = Common.Instance.Races.Keys.ToList()[race];
            CreatedCharacter.CharacterClass = Common.Instance.Classnames.Keys.ToList()[classname];
            CreatedCharacter.Name = name;
            CreatedCharacter.Background = Common.Instance.Backgrounds.Keys.ToList()[background];
            CreatedCharacter.Gender = Common.Instance.Genders.Keys.ToList()[gender];
            CreatedCharacter.Level = level;
            CreatedCharacter.Alignment = Common.Instance.Alignments.Keys.ToList()[alignment];
            swapToPage2();
            rollStats();
        }
        private void raceCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            race = raceCcomboBox.SelectedIndex;
        }
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            classname = classComboBox.SelectedIndex;
        }
        private void backgroundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            background = backgroundComboBox.SelectedIndex;
        }
        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = genderComboBox.SelectedIndex;
        }
        private void alignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alignment = alignmentComboBox.SelectedIndex;
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
                Common.Instance.Races[CreatedCharacter.Race] + " " + Common.Instance.Classnames[CreatedCharacter.CharacterClass];
            characterNameLabel.Show();
            statsTableLayoutPanel.Show();
            rerollButton.Show();
            skillsTableLayoutPanel.Show();
            saveButton.Show();
        }

        private void rollStats()
        {
            if (bonusAdded)
            {
                for (int i = 0; i < Common.Instance.RacialIncreases.Count; i++)
                {
                    string TAG = Common.Instance.RacialIncreases.Keys.ToList()[i];
                    if (Common.Instance.RacialIncreases[TAG]["race"] == CreatedCharacter.Race)
                    {
                        string stat = Common.Instance.RacialIncreases[TAG]["stat"];
                        int bonus = int.Parse(Common.Instance.RacialIncreases[TAG]["bonus"]);
                        NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("stat" + stat + "numericUpDown", true)[0];
                        numericUpDown.Minimum += bonus;
                        bonusAdded = false;
                    }
                }
            }
            DiceRolls diceRolls = new DiceRolls();
            for (int i = 0; i < Common.Instance.Stats.Count; i++)
            {
                diceRolls.Clear();
                string TAG = Common.Instance.Stats.Keys.ToList()[i];
                NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("stat" + TAG + "numericUpDown", true)[0];
                for (int j = 0; j < int.Parse(Common.Instance.Defines["stat-dice-rolled"]); j++)
                {
                    diceRolls.AddDie(int.Parse(Common.Instance.Defines["stat-dice-faces"]));
                }
                List<int> rolls = diceRolls.Roll()[int.Parse(Common.Instance.Defines["stat-dice-faces"])];
                rolls.Sort();
                for (int j = 0; j < int.Parse(Common.Instance.Defines["stat-dice-ignored"]); j++)
                {
                    rolls.RemoveAt(0);
                }
                int statValue = rolls.Sum() + (int)(numericUpDown.Minimum) - int.Parse(Common.Instance.Defines["stat-dice-rolled"]);
                if (statValue < (int)(numericUpDown.Minimum)) statValue = (int)(numericUpDown.Minimum);
                if (statValue > (int)(numericUpDown.Maximum)) statValue = (int)(numericUpDown.Maximum);
                numericUpDown.Value = statValue;
                CreatedCharacter.Stats.Set(TAG, statValue);
            }
        }
        private void handleRecalcProfiencies(object sender, EventArgs e)
        {
            for (int i = 0; i < Common.Instance.Stats.Count; i++)
            {
                string TAG = Common.Instance.Stats.Keys.ToList()[i];
                NumericUpDown numericUpDown = (NumericUpDown)Controls.Find("stat" + TAG + "numericUpDown", true)[0];
                CreatedCharacter.Stats.Set(TAG, (int)numericUpDown.Value);
            }
            updateProficiencies();
        }
        private void updateProficiencies()
        {
            for (int i = 0; i < Common.Instance.Stats.Count; i++)
            {
                string TAG = Common.Instance.Stats.Keys.ToList()[i];
                Label label = (Label)Controls.Find("proficiency" + Common.Instance.Stats.Keys.ToList()[i] + "label", true)[0];
                for (int j = Common.Instance.Proficiencies.Count - 1; j >= 0; j--)
                {
                    if (int.Parse(Common.Instance.Proficiencies.Keys.ToList()[j]) <= CreatedCharacter.Stats.Get(TAG))
                    {
                        string prof = Common.Instance.Proficiencies.Values.ToList()[j];
                        CreatedCharacter.Saves.Set(TAG, prof);
                        label.Text = prof;
                        break;
                    }
                }
            }
            for (int i = 0; i < Common.Instance.Skills.Count; i++)
            {
                string TAG = Common.Instance.Skills.Keys.ToList()[i];
                string stat = Common.Instance.Skills[TAG]["stat"];
                Label label = (Label)Controls.Find("skill" + TAG + "label", true)[0];
                label.Text = CreatedCharacter.Saves.Get(stat) + " " + Common.Instance.Skills[TAG]["name"] + " (" + Common.Instance.Skills[TAG]["stat"] + ")";
                CreatedCharacter.Skills.Set(TAG, CreatedCharacter.Saves.Get(stat));
            }
        }
        private void rerollButton_Click(object sender, EventArgs e)
        {
            rollStats();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            CreatedCharacter.ArmorClass = 10 + int.Parse(CreatedCharacter.Saves.Get(Common.Instance.Defines["armor-class-stat"]));
            CreatedCharacter.InitiativeModifier = int.Parse(CreatedCharacter.Saves.Get(Common.Instance.Defines["armor-class-stat"]));
            CreatedCharacter.PassiveWisdomPerception = 10 + int.Parse(CreatedCharacter.Saves.Get(Common.Instance.Defines["passive-perception-stat"]));
            StringBuilder sb;
            StringWriter sw;
            string path = "..\\..\\userData\\" + Properties.Settings.Default.System + "\\characters";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(path + "\\Counter.json"))
            {
                File.Create(path + "\\Counter.json").Close();
                sb = new StringBuilder();
                sw = new StringWriter(sb);
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartObject();
                    writer.WritePropertyName("max-id");
                    writer.WriteValue(0);
                    writer.WriteEnd();
                }
                File.WriteAllText(path + "\\Counter.json", sb.ToString());
            }
            Dictionary<string, string> Counter = Utils.parseJSON<Dictionary<string, string>>(path + "\\Counter.json");
            int maxId = int.Parse(Counter["max-id"]);
            File.Create(path + "\\" + maxId + ".json").Close();
            sb = new StringBuilder();
            sw = new StringWriter(sb);
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();
                writer.WritePropertyName("id");
                writer.WriteValue(maxId);
                writer.WritePropertyName("name");
                writer.WriteValue(CreatedCharacter.Name);
                writer.WritePropertyName("type");
                writer.WriteValue(CreatedCharacter.Type);
                writer.WritePropertyName("description");
                writer.WriteValue(CreatedCharacter.Description);
                writer.WritePropertyName("src");
                writer.WriteValue(CreatedCharacter.Src);
                writer.WritePropertyName("race");
                writer.WriteValue(CreatedCharacter.Race);
                writer.WritePropertyName("gender");
                writer.WriteValue(CreatedCharacter.Gender);
                writer.WritePropertyName("characterClass");
                writer.WriteValue(CreatedCharacter.CharacterClass);
                writer.WritePropertyName("level");
                writer.WriteValue(CreatedCharacter.Level);
                writer.WritePropertyName("background");
                writer.WriteValue(CreatedCharacter.Background);
                writer.WritePropertyName("alignment");
                writer.WriteValue(CreatedCharacter.Alignment);
                writer.WritePropertyName("stats");
                writer.WriteStartObject();
                for (int i = 0; i < CreatedCharacter.Stats.Count; i++)
                {
                    string TAG = CreatedCharacter.Stats.Keys.ToList()[i];
                    writer.WritePropertyName(TAG);
                    writer.WriteValue(CreatedCharacter.Stats[TAG]);
                }
                writer.WriteEnd();
                writer.WritePropertyName("proficiencyBonus");
                writer.WriteValue(CreatedCharacter.ProficiencyBonus);
                writer.WritePropertyName("armorClass");
                writer.WriteValue(CreatedCharacter.ArmorClass);
                writer.WritePropertyName("initiative");
                writer.WriteValue(CreatedCharacter.Initiative);
                writer.WritePropertyName("speed");
                writer.WriteValue(CreatedCharacter.Speed);
                writer.WritePropertyName("currentHitPoints");
                writer.WriteValue(CreatedCharacter.CurrentHitPoints);
                writer.WritePropertyName("temporaryHitPoints");
                writer.WriteValue(CreatedCharacter.TemporaryHitPoints);
                writer.WritePropertyName("personalityTraits");
                writer.WriteValue(CreatedCharacter.PersonalityTraits);
                writer.WritePropertyName("ideals");
                writer.WriteValue(CreatedCharacter.Ideals);
                writer.WritePropertyName("bonds");
                writer.WriteValue(CreatedCharacter.Bonds);
                writer.WritePropertyName("flaws");
                writer.WriteValue(CreatedCharacter.Flaws);
                writer.WritePropertyName("hitDice");
                writer.WriteValue(CreatedCharacter.HitDice);
                writer.WritePropertyName("deathSavesFail");
                writer.WriteValue(CreatedCharacter.DeathSavesFail);
                writer.WritePropertyName("deathSavesSuccess");
                writer.WriteValue(CreatedCharacter.DeathSavesSuccess);
                writer.WritePropertyName("featuresAndTraits");
                writer.WriteValue(CreatedCharacter.FeaturesAndTraits);
                writer.WritePropertyName("otherProficienciesAndLanguages");
                writer.WriteValue(CreatedCharacter.OtherProficienciesAndLanguages);
                writer.WritePropertyName("money");
                writer.WriteStartObject();
                for (int i = 0; i < CreatedCharacter.Money.Count; i++)
                {
                    string TAG = CreatedCharacter.Money.Keys.ToList()[i];
                    writer.WritePropertyName(TAG);
                    writer.WriteValue(CreatedCharacter.Money[TAG]);
                }
                writer.WriteEnd();
                writer.WritePropertyName("items");
                writer.WriteStartObject();
                for (int i = 0; i < CreatedCharacter.Items.Count; i++)
                {
                    int TAG = CreatedCharacter.Items[i];
                    writer.WritePropertyName(TAG.ToString());
                }
                writer.WriteEnd();
                writer.WritePropertyName("attacksAndSpells");
                writer.WriteStartObject();
                for (int i = 0; i < CreatedCharacter.AttacksAndSpells.Count; i++)
                {
                    int TAG = CreatedCharacter.AttacksAndSpells[i];
                    writer.WritePropertyName(TAG.ToString());
                }
                writer.WriteEnd();
                writer.WritePropertyName("saves");
                writer.WriteStartObject();
                for (int i = 0; i < CreatedCharacter.Saves.Count; i++)
                {
                    string TAG = CreatedCharacter.Saves.Keys.ToList()[i];
                    writer.WritePropertyName(TAG);
                    writer.WriteValue(CreatedCharacter.Saves[TAG]);
                }
                writer.WriteEnd();
                writer.WritePropertyName("skills");
                writer.WriteStartObject();
                for (int i = 0; i < CreatedCharacter.Skills.Count; i++)
                {
                    string TAG = CreatedCharacter.Skills.Keys.ToList()[i];
                    writer.WritePropertyName(TAG);
                    writer.WriteValue(CreatedCharacter.Skills[TAG]);
                }
                writer.WriteEnd();
                writer.WritePropertyName("passiveWisdomPerception");
                writer.WriteValue(CreatedCharacter.PassiveWisdomPerception);
                writer.WritePropertyName("age");
                writer.WriteValue(CreatedCharacter.Age);
                writer.WritePropertyName("height");
                writer.WriteValue(CreatedCharacter.Height);
                writer.WritePropertyName("weight");
                writer.WriteValue(CreatedCharacter.Weight);
                writer.WritePropertyName("eyes");
                writer.WriteValue(CreatedCharacter.Eyes);
                writer.WritePropertyName("skin");
                writer.WriteValue(CreatedCharacter.Skin);
                writer.WritePropertyName("hair");
                writer.WriteValue(CreatedCharacter.Hair);
                writer.WritePropertyName("alliesAndOrgs");
                writer.WriteValue(CreatedCharacter.AlliesAndOrgs);
                writer.WriteEnd();
            }
            File.WriteAllText(path + "\\" + maxId + ".json", sb.ToString());
            sb = new StringBuilder();
            sw = new StringWriter(sb);
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();
                writer.WritePropertyName("max-id");
                writer.WriteValue(maxId+1);
                writer.WriteEnd();
            }
            File.WriteAllText(path + "\\Counter.json", sb.ToString());
            string message = "Character saved!";
            MessageBox.Show(message);
            Close();
        }
    }
}