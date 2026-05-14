using System.Windows.Forms;

namespace DeadLine_Maxing.Services
{
    internal class NotificationService
    {
        public static void ShowNotification(
            NotifyIcon trayIcon,
            string title,
            string message)
        {
            trayIcon.ShowBalloonTip(
                3000,
                title,
                message,
                ToolTipIcon.Info);
        }
    }
}