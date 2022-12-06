namespace RPGWonder
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.mapTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.coords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapTableLayout
            // 
            this.mapTableLayout.BackgroundImage = global::RPGWonder.Properties.Resources.map_placeholder;
            resources.ApplyResources(this.mapTableLayout, "mapTableLayout");
            this.mapTableLayout.Name = "mapTableLayout";
            // 
            // coords
            // 
            resources.ApplyResources(this.coords, "coords");
            this.coords.Name = "coords";
            // 
            // Game
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.coords);
            this.Controls.Add(this.mapTableLayout);
            this.Name = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mapTableLayout;
        private System.Windows.Forms.Label coords;
    }
}