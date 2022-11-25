using RPGWonder.src.common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            for (int i = 0; i < Common.Instance.Races.Count ; i++)
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
                string TAG = Common.Instance.Skills.Keys.ToList()[i];
                Label label = new Label();
                label.Name = "skill" + TAG + "label";
                label.Text = "--";
                skillsTableLayoutPanel.Controls.Add(label);
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
                try
                {
                    createdCharacter.Stats.Add(TAG, 0);
                }
                catch
                {
                    createdCharacter.Stats[TAG] = 0;
                }
            }
            for (int i = 0; i < Common.Instance.Skills.Count; i++)
            {
                string TAG = Common.Instance.Skills.Keys.ToList()[0];
                try
                {
                    createdCharacter.Skills.Add(TAG, "+0");
                }
                catch
                {
                    createdCharacter.Skills[TAG] = "+0";
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
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
            CreatedCharacter.CharacterName = name;
            CreatedCharacter.Background = Common.Instance.Backgrounds.Keys.ToList()[background];
            CreatedCharacter.Gender = Common.Instance.Genders.Keys.ToList()[gender];
            CreatedCharacter.Level = level;
            CreatedCharacter.Alignment = Common.Instance.Alignments.Keys.ToList()[alignment];
            swapToPage2();
            rollStats();
            updateProficiencies();
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
            characterNameLabel.Text = CreatedCharacter.CharacterName +"\t Lv" + CreatedCharacter.Level + " " +
                Common.Instance.Races[CreatedCharacter.Race] + " " + Common.Instance.Classnames[CreatedCharacter.CharacterClass];
            characterNameLabel.Show();
            statsTableLayoutPanel.Show();
            rerollButton.Show();
            skillsTableLayoutPanel.Show();
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
                CreatedCharacter.Stats[TAG] = statValue;
            }
        }

        private void handleRecalcProfiencies(object sender, System.EventArgs e)
        {
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
                    try
                    {
                        if (int.Parse(Common.Instance.Proficiencies.Keys.ToList()[j]) <= CreatedCharacter.Stats[TAG])
                        {
                            string prof = Common.Instance.Proficiencies.Values.ToList()[j];
                            CreatedCharacter.Skills[TAG] = prof;
                            label.Text = prof;
                            break;
                        }
                    }
                    catch (KeyNotFoundException)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < Common.Instance.Skills.Count; i++)
            {
                string TAG = Common.Instance.Skills.Keys.ToList()[i];
                Label label = (Label)Controls.Find("skill" + TAG + "label", true)[0];
                label.Text = CreatedCharacter.Skills[TAG] + Common.Instance.Skills[TAG]["name"] + " (" + Common.Instance.Skills[TAG]["stat"] + ")";
            }
        }

        private void personalityTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rerollButton_Click(object sender, EventArgs e)
        {
            rollStats();
        }
    }
}
