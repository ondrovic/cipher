using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Cipher
{
    public partial class Cipher : XtraForm
    {
        public Cipher()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            labelUsername.Text = $"Welcome, {Environment.UserName.ToUpperInvariant()}";
            tboxPassword.Text = Common.Methods.AssemblePassword(DateTime.Today);
            tboxPassword.Properties.UseSystemPasswordChar = true;
        }

        private void ToggleSwitch_Toggled(object sender, EventArgs e)
        {
            tboxPassword.Properties.UseSystemPasswordChar = toggleSwitch.IsOn;
        }

        private void CopyPasswordToClipboard(object sender, EventArgs e)
        {
            Clipboard.SetText(tboxPassword.Text);
        }

        private void PasswordDoubleClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            CopyPasswordToClipboard(sender, e);
        }

        private void Tray_Click(object sender, MouseEventArgs e)
        {
            trayMenu.Show(Cursor.Position);
        }

        private void Tray_DoubleClick(object sender, EventArgs e)
        {
            RestoreWindow();
        }

        private void Cipher_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                tray.Visible = true;
            }
        }

        private void Cipher_FormClosing(object sender, FormClosingEventArgs e)
        {
            tray.Visible = false;
        }

        private void RestoreWindow_Click(object sender, EventArgs e)
        {
            RestoreWindow();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestoreWindow()
        {
            Show();
            WindowState = FormWindowState.Normal;
            tray.Visible = false;
        }
    }
}
