namespace RPGWonder
{
    partial class Host
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
            this.charlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // charlabel
            // 
            this.charlabel.AutoSize = true;
            this.charlabel.Location = new System.Drawing.Point(392, 189);
            this.charlabel.Name = "charlabel";
            this.charlabel.Size = new System.Drawing.Size(46, 17);
            this.charlabel.TabIndex = 0;
            this.charlabel.Text = "label1";
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 763);
            this.Controls.Add(this.charlabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Host";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Host_Load);
            this.Controls.SetChildIndex(this.charlabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charlabel;
    }
}