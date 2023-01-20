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
            this.DiceRollMenu = new System.Windows.Forms.Button();
            this.coords = new System.Windows.Forms.Label();
            this.charactersTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.charlabel = new System.Windows.Forms.Label();
            this.controlsLayoutPanel.SuspendLayout();
            this.charactersTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.controlsLayoutPanel.Controls.Add(this.DiceRollMenu, 0, 4);
            this.controlsLayoutPanel.Controls.Add(this.coords, 0, 0);
            this.controlsLayoutPanel.Controls.Add(this.charactersTabs, 0, 1);
            this.controlsLayoutPanel.Controls.Add(this.charlabel, 1, 0);
            this.controlsLayoutPanel.Name = "controlsLayoutPanel";
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
            // charactersTabs
            // 
            resources.ApplyResources(this.charactersTabs, "charactersTabs");
            this.controlsLayoutPanel.SetColumnSpan(this.charactersTabs, 3);
            this.charactersTabs.Controls.Add(this.tabPage1);
            this.charactersTabs.Controls.Add(this.tabPage2);
            this.charactersTabs.Name = "charactersTabs";
            this.controlsLayoutPanel.SetRowSpan(this.charactersTabs, 3);
            this.charactersTabs.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.Client_Load);
            this.controlsLayoutPanel.ResumeLayout(false);
            this.charactersTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mapTableLayout;
        private System.Windows.Forms.TableLayoutPanel controlsLayoutPanel;
        private System.Windows.Forms.Button DiceRollMenu;
        private System.Windows.Forms.Label coords;
        private System.Windows.Forms.TabControl charactersTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label charlabel;
    }
}