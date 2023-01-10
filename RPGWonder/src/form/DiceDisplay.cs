using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        private DiceRolls Roller = new DiceRolls();
        private Dictionary<int, List<int>> LastRolls = new Dictionary<int, List<int>>();

        /// <summary>
        /// Initialize dice display and listView columns.
        /// </summary>
        public DiceDisplay()
        {
            InitializeComponent();
            SetMotif();
            RollsList.Columns.Add("ID", 0);
            RollsList.Columns.Add("Dice", 40);
            RollsList.Columns.Add("Rolls", 120);
            RollsList.View = View.Details;
        }

        private void DiceDisplay_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handle <c>Roll</c> button click - perform the roll and display the result.
        /// </summary>
        private void RollButton_Click(object sender, EventArgs e)
        {
            LastRolls = Roller.Roll();

            UpdateDisplay();
        }

        /// <summary>
        /// Handle <c>Add die</c> button click - increase the die count and display the ammount.
        /// </summary>
        private void AddDie_Click(object sender, EventArgs e)
        {
            int added = Int32.Parse(addedDieUpDown.Text);
            Roller.AddDie(added);
            UpdateDisplay();
        }

        /// <summary>
        /// Handle <c>Sub die</c> button click - decrease the die count and display the ammount.
        /// </summary>
        private void SubDie_Click(object sender, EventArgs e)
        {
            int subbed = Int32.Parse(subbedDieUpDown.Text);
            Roller.SubDie(subbed);
            UpdateDisplay();
        }

        private void AddedDieUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SubbedDieUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Update values in <c>Dice</c> label and <c>RollsList ListView</c>.
        /// </summary>
        private void UpdateDisplay()
        {
            DiceList.Text = "Dice:" + Roller.StringDie();

            RollsList.Items.Clear();

            foreach (KeyValuePair<int, List<int>> roll in LastRolls)
            {
                ListViewItem TempLVItem = new ListViewItem();
                TempLVItem.SubItems.Add(roll.Key.ToString());
                TempLVItem.SubItems.Add(string.Join(", ", roll.Value));

                RollsList.Items.Add(TempLVItem);
            }
        }

        private void RollsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Perform <c>Roll</c> button function when Enter key is pressed, unless any of the UpDowns is focused.
        /// </summary>
        private void DiceDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&
                !(addedDieUpDown as Control).Focused &&
                !(subbedDieUpDown as Control).Focused)
            {
                Roll.PerformClick();
            }
        }

        /// <summary>
        /// Perform <c>Add die</c> button function when Enter key is pressed and corresponding UpDown is focused.
        /// </summary>
        private void AddUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddDie.PerformClick();
            }
        }

        /// <summary>
        /// Perform <c>Sub die</c> button function when Enter key is pressed and corresponding UpDown is focused.
        /// </summary>
        private void SubUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubDie.PerformClick();
            }
        }
    }
}
