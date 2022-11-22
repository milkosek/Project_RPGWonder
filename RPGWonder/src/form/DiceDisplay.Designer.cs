
namespace RPGWonder.src.form
{
    partial class DiceDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
            this.Roll = new System.Windows.Forms.Button();
            this.AddDie = new System.Windows.Forms.Button();
            this.SubDie = new System.Windows.Forms.Button();
            this.DiceList = new System.Windows.Forms.Label();
            this.addedDieUpDown = new System.Windows.Forms.NumericUpDown();
            this.subbedDieUpDown = new System.Windows.Forms.NumericUpDown();
            this.RollsList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.addedDieUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subbedDieUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(81, 83);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(75, 23);
            this.Roll.TabIndex = 0;
            this.Roll.Text = "Roll";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // AddDie
            // 
            this.AddDie.Location = new System.Drawing.Point(81, 131);
            this.AddDie.Name = "AddDie";
            this.AddDie.Size = new System.Drawing.Size(75, 28);
            this.AddDie.TabIndex = 1;
            this.AddDie.Text = "Add die";
            this.AddDie.UseVisualStyleBackColor = true;
            this.AddDie.Click += new System.EventHandler(this.AddDie_Click);
            // 
            // SubDie
            // 
            this.SubDie.Location = new System.Drawing.Point(81, 181);
            this.SubDie.Name = "SubDie";
            this.SubDie.Size = new System.Drawing.Size(75, 33);
            this.SubDie.TabIndex = 2;
            this.SubDie.Text = "Sub die";
            this.SubDie.UseVisualStyleBackColor = true;
            this.SubDie.Click += new System.EventHandler(this.SubDie_Click);
            // 
            // DiceList
            // 
            this.DiceList.AutoSize = true;
            this.DiceList.Location = new System.Drawing.Point(200, 86);
            this.DiceList.Name = "DiceList";
            this.DiceList.Size = new System.Drawing.Size(44, 17);
            this.DiceList.TabIndex = 3;
            this.DiceList.Text = "Dice: ";
            // 
            // addedDieUpDown
            // 
            this.addedDieUpDown.Location = new System.Drawing.Point(203, 135);
            this.addedDieUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addedDieUpDown.Name = "addedDieUpDown";
            this.addedDieUpDown.Size = new System.Drawing.Size(120, 22);
            this.addedDieUpDown.TabIndex = 6;
            this.addedDieUpDown.ValueChanged += new System.EventHandler(this.AddedDieUpDown_ValueChanged);
            this.addedDieUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddUpDown_KeyDown);
            // 
            // subbedDieUpDown
            // 
            this.subbedDieUpDown.Location = new System.Drawing.Point(203, 187);
            this.subbedDieUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.subbedDieUpDown.Name = "subbedDieUpDown";
            this.subbedDieUpDown.Size = new System.Drawing.Size(120, 22);
            this.subbedDieUpDown.TabIndex = 7;
            this.subbedDieUpDown.ValueChanged += new System.EventHandler(this.SubbedDieUpDown_ValueChanged);
            this.subbedDieUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubUpDown_KeyDown);
            // 
            // RollsList
            // 
            this.RollsList.HideSelection = false;
            this.RollsList.Location = new System.Drawing.Point(367, 131);
            this.RollsList.Name = "RollsList";
            this.RollsList.Size = new System.Drawing.Size(260, 293);
            this.RollsList.TabIndex = 8;
            this.RollsList.UseCompatibleStateImageBehavior = false;
            this.RollsList.SelectedIndexChanged += new System.EventHandler(this.RollsList_SelectedIndexChanged);
            // 
            // DiceDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RollsList);
            this.Controls.Add(this.subbedDieUpDown);
            this.Controls.Add(this.addedDieUpDown);
            this.Controls.Add(this.DiceList);
            this.Controls.Add(this.SubDie);
            this.Controls.Add(this.AddDie);
            this.Controls.Add(this.Roll);
            this.KeyPreview = true;
            this.Name = "DiceDisplay";
            this.Text = "DiceDisplay";
            this.Load += new System.EventHandler(this.DiceDisplay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiceDisplay_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.addedDieUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subbedDieUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddDie;
        private System.Windows.Forms.Button SubDie;
        private System.Windows.Forms.Label DiceList;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.NumericUpDown addedDieUpDown;
        private System.Windows.Forms.NumericUpDown subbedDieUpDown;
        private System.Windows.Forms.ListView RollsList;
    }
}