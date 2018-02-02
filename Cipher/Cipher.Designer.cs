namespace Cipher
{
    partial class Cipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cipher));
            this.style = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tboxPassword = new DevExpress.XtraEditors.TextEdit();
            this.toggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelUsername = new DevExpress.XtraEditors.LabelControl();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tboxPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).BeginInit();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // style
            // 
            this.style.LookAndFeel.SkinName = "Metropolis Dark";
            // 
            // tboxPassword
            // 
            this.tboxPassword.EditValue = "PASSWORD";
            this.tboxPassword.Location = new System.Drawing.Point(13, 51);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Properties.AllowFocused = false;
            this.tboxPassword.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 18.25F);
            this.tboxPassword.Properties.Appearance.Options.UseFont = true;
            this.tboxPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.tboxPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tboxPassword.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tboxPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tboxPassword.Properties.ReadOnly = true;
            this.tboxPassword.Size = new System.Drawing.Size(607, 34);
            this.tboxPassword.TabIndex = 1;
            this.tboxPassword.TabStop = false;
            this.tboxPassword.DoubleClick += new System.EventHandler(this.TboxPassword_DoubleClick);
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.AutoSizeInLayoutControl = true;
            this.toggleSwitch.EditValue = true;
            this.toggleSwitch.Location = new System.Drawing.Point(553, 101);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch.Properties.Appearance.Options.UseBackColor = true;
            this.toggleSwitch.Properties.AutoWidth = true;
            this.toggleSwitch.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.toggleSwitch.Properties.LookAndFeel.SkinName = "Metropolis Dark";
            this.toggleSwitch.Properties.OffText = "Off";
            this.toggleSwitch.Properties.OnText = "On";
            this.toggleSwitch.Properties.ShowText = false;
            this.toggleSwitch.Size = new System.Drawing.Size(70, 24);
            this.toggleSwitch.TabIndex = 2;
            this.toggleSwitch.TabStop = false;
            this.toggleSwitch.Toggled += new System.EventHandler(this.ToggleSwitch_Toggled);
            // 
            // labelUsername
            // 
            this.labelUsername.Appearance.Font = new System.Drawing.Font("Consolas", 18.25F);
            this.labelUsername.Appearance.Options.UseFont = true;
            this.labelUsername.Location = new System.Drawing.Point(13, 13);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(169, 28);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Welcome, USER";
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.trayMenu;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Visible = true;
            this.tray.Click += new System.EventHandler(this.Tray_Click);
            this.tray.DoubleClick += new System.EventHandler(this.Tray_DoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPassword,
            this.restoreWindow,
            this.quit});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(161, 70);
            // 
            // copyPassword
            // 
            this.copyPassword.Image = ((System.Drawing.Image)(resources.GetObject("copyPassword.Image")));
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(160, 22);
            this.copyPassword.Text = "Copy Password";
            this.copyPassword.Click += new System.EventHandler(this.CopyPassword_Click);
            // 
            // restoreWindow
            // 
            this.restoreWindow.Image = ((System.Drawing.Image)(resources.GetObject("restoreWindow.Image")));
            this.restoreWindow.Name = "restoreWindow";
            this.restoreWindow.Size = new System.Drawing.Size(160, 22);
            this.restoreWindow.Text = "Restore Window";
            this.restoreWindow.Click += new System.EventHandler(this.RestoreWindow_Click);
            // 
            // quit
            // 
            this.quit.Image = ((System.Drawing.Image)(resources.GetObject("quit.Image")));
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(160, 22);
            this.quit.Text = "Quit";
            this.quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Cipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(632, 137);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.toggleSwitch);
            this.Controls.Add(this.tboxPassword);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(648, 176);
            this.Name = "Cipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cipher";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cipher_FormClosing);
            this.Resize += new System.EventHandler(this.Cipher_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tboxPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).EndInit();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel style;
        private DevExpress.XtraEditors.TextEdit tboxPassword;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch;
        private DevExpress.XtraEditors.LabelControl labelUsername;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem copyPassword;
        private System.Windows.Forms.ToolStripMenuItem restoreWindow;
        private System.Windows.Forms.ToolStripMenuItem quit;
    }
}

