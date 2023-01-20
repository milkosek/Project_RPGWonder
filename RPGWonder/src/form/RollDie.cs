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
    public partial class RollDie : DefaultForm
    {
        private int _bonus;
        private string _ability;
        private int _difficulty;

        public RollDie(int currentBonus, string ability)
        {
            InitializeComponent();
            _bonus = currentBonus;
            _ability = ability;
        }

        private void RollDie_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            titleLabel.Text = "Rolling for " + Common.Instance.Abilities[_ability]["name"];
            bonusTextBox.Text = _bonus.ToString();
            foreach (KeyValuePair<string, JToken> difficulty in Common.Instance.TaskDifficulties)
            {
                ComboBoxObject comboBoxObject = new ComboBoxObject
                {
                    Key = (string)difficulty.Value["difficulty class"],
                    Value = difficulty.Value["name"] + " (" + difficulty.Value["difficulty class"] + ")"
                };
                difficultyComboBox.Items.Add(comboBoxObject);
            }
            difficultyComboBox.SelectedIndex = 0;
            SetMotif();
            rollButton.BackColor = Color.SteelBlue;
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            _bonus = int.Parse(bonusTextBox.Text);
            _difficulty = int.Parse(((ComboBoxObject)difficultyComboBox.SelectedItem).Key);
            //Do whatever you want with the result now, idk.
            KeyValuePair<int, bool> result = rollDie();
            Debug.WriteLine(result);
        }

        private KeyValuePair<int, bool> rollDie()
        {
            DiceRolls diceRolls = new DiceRolls();
            diceRolls.AddDie(20);
            int roll = diceRolls.Roll()[20][0];
            if ((string)Common.Instance.Defines["difficulty-die-always-success-apply-post-throw"] == "false")
            {
                JArray array = (JArray)Common.Instance.Defines["difficulty-die-always-success"];
                List<int> list = array.Select(x => (int)x).ToList();
                if (list.Contains(roll))
                {
                    return new KeyValuePair<int, bool>(roll, true);
                }
            }
            if ((string)Common.Instance.Defines["difficulty-die-always-failure-apply-post-throw"] == "false")
            {
                JArray array = (JArray)Common.Instance.Defines["difficulty-die-always-failure"];
                List<int> list = array.Select(x => (int)x).ToList();
                if (list.Contains(roll))
                {
                    return new KeyValuePair<int, bool>(roll, false);
                }
            }
            roll += _bonus;
            if ((string)Common.Instance.Defines["difficulty-die-always-success-apply-post-throw"] == "true")
            {
                JArray array = (JArray)Common.Instance.Defines["difficulty-die-always-success"];
                List<int> list = array.Select(x => (int)x).ToList();
                if (list.Contains(roll))
                {
                    return new KeyValuePair<int, bool>(roll, true);
                }
            }
            if ((string)Common.Instance.Defines["difficulty-die-always-failure-apply-post-throw"] == "true")
            {
                JArray array = (JArray)Common.Instance.Defines["difficulty-die-always-failure"];
                List<int> list = array.Select(x => (int)x).ToList();
                if (list.Contains(roll))
                {
                    return new KeyValuePair<int, bool>(roll, false);
                }
            }
            if (roll >= _difficulty)
            {
                return new KeyValuePair<int, bool>(roll, true);
            }
            return new KeyValuePair<int, bool>(roll, false);
        }
    }
}
