using System;
using System.Collections.Generic;

namespace DeadLine_Maxing.Models
{
    public class TaskItem
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public string Difficulty { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }

        public bool Reminder24HoursSent { get; set; }

        public bool Reminder5HoursSent { get; set; }

        public List<string> AttachedFiles { get; set; }
            = new List<string>();

        public List<ChecklistItem> Checklist { get; set; }
            = new List<ChecklistItem>();
    }
}