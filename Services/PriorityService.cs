using DeadLine_Maxing.Models;
using System;

namespace DeadLine_Maxing.Services
{
    internal class PriorityService
    {
        public static string CalculatePriority(TaskItem task)
        {
            TimeSpan remaining =
                task.Deadline - DateTime.Now;

            if (remaining.TotalHours <= 24)
                return "High";

            if (task.Difficulty == "Hard")
                return "High";

            if (remaining.TotalDays <= 3)
                return "Medium";

            if (task.Difficulty == "Medium")
                return "Medium";

            return "Low";
        }
    }
}