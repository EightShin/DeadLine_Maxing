using Microsoft.Win32;
using System.Windows.Forms;

namespace DeadLine_Maxing.Services
{
    internal class StartupService
    {
        private const string AppName = "DeadLineMaxing";

        public static void EnableStartup()
        {
            try
            {
                RegistryKey key =
                    Registry.CurrentUser.OpenSubKey(
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                        true);

                key.SetValue(
                    "DeadLine Maxing",
                    Application.ExecutablePath);
            }
            catch
            {
                MessageBox.Show(
                    "Unable to enable startup.");
            }
        }

        public static void DisableStartup()
        {
            try
            {
                RegistryKey key =
                    Registry.CurrentUser.OpenSubKey(
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                        true);

                key.DeleteValue(
                    "DeadLine Maxing",
                    false);
            }
            catch
            {
                MessageBox.Show(
                    "Unable to disable startup.");
            }
        }
    }
}