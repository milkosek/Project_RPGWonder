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
            this.exitButton = new System.Windows.Forms.Button();
            this.charactersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.turnLabel = new System.Windows.Forms.Label();
            this.charlabel = new System.Windows.Forms.Label();
            this.DiceRollMenu = new System.Windows.Forms.Button();
            this.coords = new System.Windows.Forms.Label();
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
            this.controlsLayoutPanel.Controls.Add(this.exitButton, 2, 4);
            this.controlsLayoutPanel.Controls.Add(this.charactersListView, 0, 1);
            this.controlsLayoutPanel.Controls.Add(this.turnLabel, 2, 0);
            this.controlsLayoutPanel.Controls.Add(this.charlabel, 1, 0);
            this.controlsLayoutPanel.Controls.Add(this.DiceRollMenu, 0, 4);
            this.controlsLayoutPanel.Controls.Add(this.coords, 0, 0);
            this.controlsLayoutPanel.Name = "controlsLayoutPanel";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // charactersListView
            // 
            resources.ApplyResources(this.charactersListView, "charactersListView");
            this.charactersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.controlsLayoutPanel.SetColumnSpan(this.charactersListView, 3);
            this.charactersListView.FullRowSelect = true;
            this.charactersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.charactersListView.HideSelection = false;
            this.charactersListView.Name = "charactersListView";
            this.controlsLayoutPanel.SetRowSpan(this.charactersListView, 3);
            this.charactersListView.UseCompatibleStateImageBehavior = false;
            this.charactersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // turnLabel
            // 
            resources.ApplyResources(this.turnLabel, "turnLabel");
            this.turnLabel.Name = "turnLabel";
            // 
            // charlabel
            // 
            resources.ApplyResources(this.charlabel, "charlabel");
            this.charlabel.Name = "charlabel";
            // 
            // DiceRollMenu
            // 
            resources.ApplyResources(this.DiceRollMenu, "DiceRollMenu");
            this.DiceRollMenu.Name = "DiceRollMenu";
            this.DiceRollMenu.UseVisualStyleBackColor = true;
            this.DiceRollMenu.Click += new System.EventHandler(this.DiceRollMenu_Click_1);
            // 
            // coords
            // 
            resources.ApplyResources(this.coords, "coords");
            this.coords.Name = "coords";
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
        private System.Windows.Forms.ListView charactersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button exitButton;
    }
}