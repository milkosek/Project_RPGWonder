using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGWonder
{ 
    public partial class ShowCharacter : DefaultForm
    {
        private Character _character;
        private static ShowCharacter _instance = null;

        public static ShowCharacter Instance(Character character)
        {
            if(_instance == null)
            {
                _instance = new ShowCharacter(character);
            }
            return _instance;
        }

        public ShowCharacter(Character character)
        {
            _character = character;
            InitializeComponent();
        }

        private void ShowCharacter_Load(object sender, EventArgs e)
        {
            characterNameLabel.Text = _character.Name;
            raceTextBox.Text = (string)Common.Instance.Races[_character.Race]["name"];
            classTextBox.Text = (string)Common.Instance.Classes[_character.CharacterClass]["name"];
            backgroundTextBox.Text = (string)Common.Instance.Backgrounds[_character.Background];
            personalityTextBox.Text = _character.PersonalityTraits;
            bondTextBox.Text = _character.Bonds;
            genderTextBox.Text = (string)Common.Instance.Genders[_character.Gender];
            levelTextBox.Text = _character.Level.ToString();
            alignmentTextBox.Text = (string)Common.Instance.Alignments[_character.Alignment];
            idealTextBox.Text = _character.Ideals;
            flawTextBox.Text = _character.Flaws;
            abilitiesTableLayoutPanel.RowCount = Common.Instance.Abilities.Count;
            int i = 0;
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Abilities)
            {
                TextBox textBox = new TextBox
                {
                    Name = "ability" + TAG.Key + "textBox",
                    Font = new Font("Microsoft Sans Serif", 19),
                    Size = new Size(60, 45),
                    Text = _character.Abilities.Get(TAG.Key).ToString(),
                    ReadOnly = true
                };
                Label label = new Label
                {
                    Text = (string)TAG.Value["name"],
                    Name = "ability" + TAG.Key + "label"
                };
                Label proficiency = new Label
                {
                    Text = _character.Saves.Get(TAG.Key),
                    Name = "proficiency" + TAG.Key + "label",
                    Font = new Font("Microsoft Sans Serif", 14),
                    Anchor = AnchorStyles.None
                };
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
                {
                    Name = "ability" + TAG.Key + "tableLayoutPanel",
                    Size = new Size(80, 55),
                    RowStyles =
                    {
                        new RowStyle(SizeType.Percent, 75),
                        new RowStyle(SizeType.Percent, 25)
                    }
                };
                TableLayoutPanel proficiencyLayoutPanel = new TableLayoutPanel
                {
                    Name = "proficiency" + TAG.Key + "tableLayoutPanel",
                    Size = new Size(80, 55)
                };
                Button button = new Button
                {
                    Name = "ability" + TAG.Key + "button",
                    Size = new Size(40, 40),
                    Image = Properties.Resources.Die
                };
                button.Click += (s, args) => Roll(int.Parse(_character.Saves.Get(TAG.Key)), TAG.Key);
                tableLayoutPanel.Controls.Add(textBox, 0, 0);
                tableLayoutPanel.Controls.Add(label, 0, 1);
                proficiencyLayoutPanel.Controls.Add(proficiency, 0, 0);
                abilitiesTableLayoutPanel.Controls.Add(tableLayoutPanel, 0, i);
                abilitiesTableLayoutPanel.Controls.Add(proficiencyLayoutPanel, 1, i);
                abilitiesTableLayoutPanel.Controls.Add(button, 2, i);
                i++;
            }

            foreach (RowStyle style in abilitiesTableLayoutPanel.RowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 60;
            }
            foreach (KeyValuePair<string, JToken> TAG in Common.Instance.Skills)
            {
                TableLayoutPanel skillLayoutPanel = new TableLayoutPanel();
                skillLayoutPanel.Size = new Size(200, 30);
                Label label = new Label
                {
                    Width = 150,
                    Name = "skill" + TAG.Key + "label",
                    Text = _character.Saves.Get((string)Common.Instance.Skills[TAG.Key]["ability"]) + " " + Common.Instance.Skills[TAG.Key]["name"] + " (" + Common.Instance.Skills[TAG.Key]["ability"] + ")"
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
        }

        private void Roll(int currentBonus, string ability)
        {
            RollDie rollDie = new RollDie(currentBonus, ability);
            rollDie.Show();
        }
    }
}
