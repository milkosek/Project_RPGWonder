using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RPGWonder.src.net;

namespace RPGWonder.src.form
{
    public partial class DiceDisplay : DefaultForm
    {
        private static DiceDisplay instance = null;
        public static DiceDisplay Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DiceDisplay();
                }
                return instance;
            }
        }

        private DiceRolls _roller = new DiceRolls();
        private Dictionary<int, List<int>> _lastRolls = new Dictionary<int, List<int>>();

        /// <summary>
        /// Initialize dice display and listView columns.
        /// </summary>
        public DiceDisplay()
        {
            InitializeComponent();
            RollsList.Columns.Add("ID", 0);
            RollsList.Columns.Add("Dice", 60);
            RollsList.Columns.Add("Rolls", 100);
            RollsList.View = View.Details;

            TopMost = true;
        }

        private void DiceDisplay_Load(object sender, EventArgs e)
        {
            SetMotif();
            addDieButton.BackColor = Color.SeaGreen;
            subDieButton.BackColor = Color.IndianRed;
            rollButton.BackColor = Color.SteelBlue;
        }

        /// <summary>
        /// Handle <c>rollButton</c> button click - perform the roll and display the result.
        /// </summary>
        private void RollButton_Click(object sender, EventArgs e)
        {
            _lastRolls = _roller.Roll();

            DiscordChannelConnection.LogIntoTextChannel(String.Format("Rolled {0}", _lastRolls));

            UpdateDisplay();
        }

        /// <summary>
        /// Handle <c>addDieButton</c> button click - increase the die count and display the ammount.
        /// </summary>
        private void AddDie_Click(object sender, EventArgs e)
        {
            int added = (int)diceNumericUpDown.Value;
            _roller.AddDie(added);
            UpdateDisplay();
        }

        /// <summary>
        /// Handle <c>subDieButton</c> button click - decrease the die count and display the ammount.
        /// </summary>
        private void SubDie_Click(object sender, EventArgs e)
        {
            int subbed = (int)diceNumericUpDown.Value;
            _roller.SubDie(subbed);
            UpdateDisplay();
        }

        /// <summary>
        /// Update values in <c>Dice</c> label and <c>RollsList ListView</c>.
        /// </summary>
        private void UpdateDisplay()
        {
            RollsList.Items.Clear();

            foreach (KeyValuePair<int, List<int>> roll in _lastRolls)
            {
                ListViewItem TempLVItem = new ListViewItem();
                TempLVItem.SubItems.Add("d" + roll.Key.ToString());
                TempLVItem.SubItems.Add(string.Join(", ", roll.Value));

                RollsList.Items.Add(TempLVItem);
            }
            if (_roller.Count() > 0)
            {
                DiceList.Text = "Dice:" + _roller.StringDie();
                rollButton.Enabled = true;
            }
            else
            {
                DiceList.Text = "Dice: None";
                rollButton.Enabled = false;
            }
        }
    }
}
