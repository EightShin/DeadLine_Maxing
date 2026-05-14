using System;
using System.Drawing;
using System.Windows.Forms;

namespace DeadLine_Maxing.Services
{
    internal class TrayService
    {
        private NotifyIcon trayIcon;
        private Form mainForm;

        public TrayService(Form form)
        {
            mainForm = form;

            trayIcon = new NotifyIcon
            {
                Icon = SystemIcons.Application,
                Visible = true,
                Text = "Deadline Manager"
            };

            trayIcon.DoubleClick += (s, e) =>
            {
                mainForm.Show();
                mainForm.WindowState = FormWindowState.Normal;
            };
        }

        public void HandleResize()
        {
            if (mainForm.WindowState == FormWindowState.Minimized)
            {
                mainForm.Hide();

                trayIcon.ShowBalloonTip(
                    1000,
                    "Deadline Manager",
                    "App minimized to tray.",
                    ToolTipIcon.Info);
            }
        }
    }
}