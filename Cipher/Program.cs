using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Cipher
{
    static class Program
    {
        static Mutex m;
        /// <summary>
        /// Checks if Cipher is already running
        /// </summary>
        /// <returns>
        /// true : false
        /// </returns>
        static bool IsSingleInstance()
        {
            try
            {
                Mutex.OpenExisting("Cipher");
            }
            catch
            {
                m = new Mutex(true, "Cipher");
                return true;
            }

            return false;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Metropolis Dark");

            if (IsSingleInstance())
            {
                Application.Run(new Cipher());
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("{0} is already running.", Assembly.GetExecutingAssembly().GetName().Name, Environment.NewLine), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
