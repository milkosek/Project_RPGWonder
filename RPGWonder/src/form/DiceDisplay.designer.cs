namespace RPGWonder.src.form
{
    partial class DiceDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            instance = null;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rollButton = new System.Windows.Forms.Button();
            this.addDieButton = new System.Windows.Forms.Button();
            this.subDieButton = new System.Windows.Forms.Button();
            this.DiceList = new System.Windows.Forms.Label();
            this.diceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RollsList = new System.Windows.Forms.ListView();
            this.numberOFFacesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Roll
            // 
            this.rollButton.Enabled = false;
            this.rollButton.Location = new System.Drawing.Point(10, 195);
            this.rollButton.Margin = new System.Windows.Forms.Padding(2);
            this.rollButton.Name = "Roll";
            this.rollButton.Size = new System.Drawing.Size(410, 33);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // AddDie
            // 
            this.addDieButton.Location = new System.Drawing.Point(10, 116);
            this.addDieButton.Margin = new System.Windows.Forms.Padding(2);
            this.addDieButton.Name = "AddDie";
            this.addDieButton.Size = new System.Drawing.Size(75, 75);
            this.addDieButton.TabIndex = 1;
            this.addDieButton.Text = "Add die";
            this.addDieButton.UseVisualStyleBackColor = true;
            this.addDieButton.Click += new System.EventHandler(this.AddDie_Click);
            // 
            // SubDie
            // 
            this.subDieButton.Location = new System.Drawing.Point(98, 116);
            this.subDieButton.Margin = new System.Windows.Forms.Padding(2);
            this.subDieButton.Name = "SubDie";
            this.subDieButton.Size = new System.Drawing.Size(75, 75);
            this.subDieButton.TabIndex = 2;
            this.subDieButton.Text = "Sub die";
            this.subDieButton.UseVisualStyleBackColor = true;
            this.subDieButton.Click += new System.EventHandler(this.SubDie_Click);
            // 
            // DiceList
            // 
            this.DiceList.AutoSize = true;
            this.DiceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiceList.Location = new System.Drawing.Point(7, 19);
            this.DiceList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiceList.Name = "DiceList";
            this.DiceList.Size = new System.Drawing.Size(87, 20);
            this.DiceList.TabIndex = 3;
            this.DiceList.Text = "Dice: None";
            // 
            // diceNumericUpDown
            // 
            this.diceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diceNumericUpDown.Location = new System.Drawing.Point(10, 86);
            this.diceNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.diceNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.diceNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.diceNumericUpDown.Name = "diceNumericUpDown";
            this.diceNumericUpDown.Size = new System.Drawing.Size(163, 26);
            this.diceNumericUpDown.TabIndex = 6;
            this.diceNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // RollsList
            // 
            this.RollsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RollsList.HideSelection = false;
            this.RollsList.Location = new System.Drawing.Point(186, 58);
            this.RollsList.Margin = new System.Windows.Forms.Padding(2);
            this.RollsList.Name = "RollsList";
            this.RollsList.Size = new System.Drawing.Size(234, 133);
            this.RollsList.TabIndex = 8;
            this.RollsList.UseCompatibleStateImageBehavior = false;
            // 
            // numberOFFacesLabel
            // 
            this.numberOFFacesLabel.AutoSize = true;
            this.numberOFFacesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numberOFFacesLabel.Location = new System.Drawing.Point(11, 58);
            this.numberOFFacesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOFFacesLabel.Name = "numberOFFacesLabel";
            this.numberOFFacesLabel.Size = new System.Drawing.Size(116, 17);
            this.numberOFFacesLabel.TabIndex = 9;
            this.numberOFFacesLabel.Text = "Number of faces:";
            // 
            // DiceDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 235);
            this.Controls.Add(this.numberOFFacesLabel);
            this.Controls.Add(this.RollsList);
            this.Controls.Add(this.diceNumericUpDown);
            this.Controls.Add(this.DiceList);
            this.Controls.Add(this.subDieButton);
            this.Controls.Add(this.addDieButton);
            this.Controls.Add(this.rollButton);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DiceDisplay";
            this.Text = "DiceDisplay";
            this.Load += new System.EventHandler(this.DiceDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addDieButton;
        private System.Windows.Forms.Button subDieButton;
        private System.Windows.Forms.Label DiceList;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.NumericUpDown diceNumericUpDown;
        private System.Windows.Forms.ListView RollsList;
        private System.Windows.Forms.Label numberOFFacesLabel;
    }
}