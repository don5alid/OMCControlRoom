namespace OMCControlRoomApplication
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ManagerMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.LogoutMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ConnectButton = new System.Windows.Forms.ToolStripButton();
            this.DisconnectButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LogsButton = new System.Windows.Forms.ToolStripButton();
            this.LogoutButton = new System.Windows.Forms.ToolStripButton();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagerMainMenu,
            this.SettingsMainMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // ManagerMainMenu
            // 
            this.ManagerMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectMainMenuItem,
            this.DisconnectMainMenuItem,
            this.toolStripSeparator5,
            this.LogoutMainMenuItem,
            this.ExitMainMenuItem});
            this.ManagerMainMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.ManagerMainMenu.Name = "ManagerMainMenu";
            this.ManagerMainMenu.Size = new System.Drawing.Size(66, 20);
            this.ManagerMainMenu.Text = "&Manager";
            // 
            // ConnectMainMenuItem
            // 
            this.ConnectMainMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ConnectMainMenuItem.Image")));
            this.ConnectMainMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ConnectMainMenuItem.Name = "ConnectMainMenuItem";
            this.ConnectMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ConnectMainMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ConnectMainMenuItem.Text = "&Connect";
            this.ConnectMainMenuItem.Click += new System.EventHandler(this.ConnectMainMenuItem_Click);
            // 
            // DisconnectMainMenuItem
            // 
            this.DisconnectMainMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DisconnectMainMenuItem.Image")));
            this.DisconnectMainMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.DisconnectMainMenuItem.Name = "DisconnectMainMenuItem";
            this.DisconnectMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.DisconnectMainMenuItem.Size = new System.Drawing.Size(179, 22);
            this.DisconnectMainMenuItem.Text = "&Disconnect";
            this.DisconnectMainMenuItem.Click += new System.EventHandler(this.DisconnectMainMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(176, 6);
            // 
            // LogoutMainMenuItem
            // 
            this.LogoutMainMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LogoutMainMenuItem.Image")));
            this.LogoutMainMenuItem.Name = "LogoutMainMenuItem";
            this.LogoutMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.LogoutMainMenuItem.Size = new System.Drawing.Size(179, 22);
            this.LogoutMainMenuItem.Text = "Log&out";
            this.LogoutMainMenuItem.Click += new System.EventHandler(this.LogoutMainMenuItem_Click);
            // 
            // ExitMainMenuItem
            // 
            this.ExitMainMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitMainMenuItem.Image")));
            this.ExitMainMenuItem.Name = "ExitMainMenuItem";
            this.ExitMainMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMainMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ExitMainMenuItem.Text = "&Exit";
            this.ExitMainMenuItem.Click += new System.EventHandler(this.ExitMainMenuItem_Click);
            // 
            // SettingsMainMenu
            // 
            this.SettingsMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingMainMenuItem});
            this.SettingsMainMenu.Name = "SettingsMainMenu";
            this.SettingsMainMenu.Size = new System.Drawing.Size(61, 20);
            this.SettingsMainMenu.Text = "&Options";
            // 
            // SettingMainMenuItem
            // 
            this.SettingMainMenuItem.Name = "SettingMainMenuItem";
            this.SettingMainMenuItem.Size = new System.Drawing.Size(116, 22);
            this.SettingMainMenuItem.Text = "&Settings";
            this.SettingMainMenuItem.Click += new System.EventHandler(this.SettingMainMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectButton,
            this.DisconnectButton,
            this.toolStripSeparator1,
            this.LogsButton,
            this.LogoutButton,
            this.ExitButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // ConnectButton
            // 
            this.ConnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConnectButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectButton.Image")));
            this.ConnectButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(23, 22);
            this.ConnectButton.Text = "New";
            this.ConnectButton.Click += new System.EventHandler(this.ConnectMainMenuItem_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DisconnectButton.Image = ((System.Drawing.Image)(resources.GetObject("DisconnectButton.Image")));
            this.DisconnectButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(23, 22);
            this.DisconnectButton.Text = "Open";
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectMainMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // LogsButton
            // 
            this.LogsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogsButton.Image = ((System.Drawing.Image)(resources.GetObject("LogsButton.Image")));
            this.LogsButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.LogsButton.Name = "LogsButton";
            this.LogsButton.Size = new System.Drawing.Size(23, 22);
            this.LogsButton.Text = "Print Preview";
            this.LogsButton.Click += new System.EventHandler(this.LogsButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(23, 22);
            this.LogoutButton.Text = "Save";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutMainMenuItem_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(23, 22);
            this.ExitButton.Text = "Print";
            this.ExitButton.Click += new System.EventHandler(this.ExitMainMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ManagerMainMenu;
        private System.Windows.Forms.ToolStripMenuItem DisconnectMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMainMenu;
        private System.Windows.Forms.ToolStripButton ConnectButton;
        private System.Windows.Forms.ToolStripButton DisconnectButton;
        private System.Windows.Forms.ToolStripButton LogoutButton;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.ToolStripButton LogsButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ConnectMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingMainMenuItem;
    }
}



