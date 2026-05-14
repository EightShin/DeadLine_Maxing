using DeadLine_Maxing.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DeadLine_Maxing.Services
{
    internal class ReminderService
    {
        public static void CheckDeadlines(List<TaskItem> tasks)
        {
            foreach (var task in tasks)
            {
                TimeSpan remaining =
                    task.Deadline - DateTime.Now;

                if (remaining.TotalHours <= 24 &&
                   !task.Reminder24HoursSent)
                {
                    MessageBox.Show(
                        $"Task '{task.Title}' is due within 24 hours!",
                        "Deadline Reminder");

                    task.Reminder24HoursSent = true;
                }

                if (remaining.TotalHours <= 5 &&
                   !task.Reminder5HoursSent)
                {
                    MessageBox.Show(
                        $"Task '{task.Title}' is due within 5 hours!",
                        "Urgent Reminder");

                    task.Reminder5HoursSent = true;
                }
            }
        }
    }
}