using Common;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Cipher
{
    public partial class Cipher : DevExpress.XtraEditors.XtraForm
    {
        public Cipher()
        {
            InitializeComponent();
            labelUsername.Text = string.Format("Welcome, {0}", Environment.UserName.ToUpperInvariant());
            tboxPassword.Text = Methods.AssemblePassword(DateTime.Today);
            tboxPassword.Properties.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Shows and hides the password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleSwitch_Toggled(object sender, EventArgs e)
        {
           toggleSwitch.IsOn = (toggleSwitch.IsOn) ? tboxPassword.Properties.UseSystemPasswordChar = true : tboxPassword.Properties.UseSystemPasswordChar = false;
        }

        /// <summary>
        /// Copies the raw password to 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TboxPassword_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(tboxPassword.Text);
        }

        /// <summary>
        /// Copies password to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tray_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(tboxPassword.Text);
        }

        /// <summary>
        /// Restores the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tray_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            tray.Visible = false;
        }

        /// <summary>
        /// Handles the tray icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cipher_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                tray.Visible = true;
            }
        }

        /// <summary>
        /// Removes tray icon on close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cipher_FormClosing(object sender, FormClosingEventArgs e)
        {
            tray.Visible = false;
        }

        /// <summary>
        /// Copies Password to Clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(tboxPassword.Text);
        }

        /// <summary>
        /// Shows window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestoreWindow_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            tray.Visible = false;
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
