namespace RPGWonder
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.mapTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.controlsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.turnLabel = new System.Windows.Forms.Label();
            this.DiceRollMenu = new System.Windows.Forms.Button();
            this.coords = new System.Windows.Forms.Label();
            this.charlabel = new System.Windows.Forms.Label();
            this.controlsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapTableLayout
            // 
            this.mapTableLayout.BackgroundImage = global::RPGWonder.Properties.Resources.map_placeholder;
            resources.ApplyResources(this.mapTableLayout, "mapTableLayout");
            this.mapTableLayout.Name = "mapTableLayout";
            // 
            // controlsLayoutPanel
            // 
            resources.ApplyResources(this.controlsLayoutPanel, "controlsLayoutPanel");
            this.controlsLayoutPanel.Controls.Add(this.turnLabel, 2, 0);
            this.controlsLayoutPanel.Controls.Add(this.DiceRollMenu, 0, 4);
            this.controlsLayoutPanel.Controls.Add(this.coords, 0, 0);
            this.controlsLayoutPanel.Controls.Add(this.charlabel, 1, 0);
            this.controlsLayoutPanel.Name = "controlsLayoutPanel";
            // 
            // turnLabel
            // 
            resources.ApplyResources(this.turnLabel, "turnLabel");
            this.turnLabel.Name = "turnLabel";
            // 
            // DiceRollMenu
            // 
            resources.ApplyResources(this.DiceRollMenu, "DiceRollMenu");
            this.DiceRollMenu.Name = "DiceRollMenu";
            this.DiceRollMenu.UseVisualStyleBackColor = true;
            // 
            // coords
            // 
            resources.ApplyResources(this.coords, "coords");
            this.coords.Name = "coords";
            // 
            // charlabel
            // 
            resources.ApplyResources(this.charlabel, "charlabel");
            this.charlabel.Name = "charlabel";
            // 
            // Client
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlsLayoutPanel);
            this.Controls.Add(this.mapTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.controlsLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mapTableLayout;
        private System.Windows.Forms.TableLayoutPanel controlsLayoutPanel;
        private System.Windows.Forms.Button DiceRollMenu;
        private System.Windows.Forms.Label coords;
        private System.Windows.Forms.Label charlabel;
        private System.Windows.Forms.Label turnLabel;
    }
}