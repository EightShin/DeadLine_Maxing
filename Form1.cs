using DeadLine_Maxing.Models;
using DeadLine_Maxing.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DeadLine_Maxing
{
    public partial class Form1 : Form
    {
        private void Form1_Shown(
    object sender,
    EventArgs e)
        {
            if (!Properties.Settings.Default.StartupAsked)
            {
                DialogResult result =
                    MessageBox.Show(
                        "Enable app startup?",
                        "Startup",
                        MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    StartupService.EnableStartup();

                    Properties.Settings.Default
                        .StartupEnabled = true;
                }

                else
                {
                    Properties.Settings.Default
                        .StartupEnabled = false;
                }

                Properties.Settings.Default
                    .StartupAsked = true;

                Properties.Settings.Default.Save();
            }
        }

        private List<TaskItem> tasks = new List<TaskItem>();

        private TrayService trayService;

        private Timer reminderTimer = new Timer();

        public Form1()
        {
            InitializeComponent();

            dgvTasks.DefaultCellStyle.SelectionBackColor =
            Color.LightGray;

            dgvTasks.DefaultCellStyle.SelectionForeColor =
            Color.Black;

            UpdateStartupButton();

            rtbNotes.Text = NoteService.LoadNotes();

            if (string.IsNullOrWhiteSpace(rtbNotes.Text))
            {
                rtbNotes.Text =
            @"// Quick notes

            SELECT * FROM Students;

            Console.WriteLine(""Hello World"");";
            }

            trayService = new TrayService(this);

            ThemeService.ApplyTheme(this);

            tasks = TaskStorageService.LoadTasks();

            RefreshTaskList();

            reminderTimer.Interval = 5000;

            reminderTimer.Tick += ReminderTimer_Tick;

            reminderTimer.Start();

            lblEmpty.Visible = tasks.Count == 0;

            toolTip1.SetToolTip(
            btnOpenTaskForm,
            "Create a new task");

            toolTip1.SetToolTip(
                btnDeleteTask,
                "Delete selected task");

            toolTip1.SetToolTip(
                btnToggleTheme,
                "Switch light/dark mode");

            toolTip1.SetToolTip(
                btnStartup,
                "Enable app startup");

            toolTip1.SetToolTip(
                rtbNotes,
                "Write quick notes or code snippets");

        }

        private void UpdateStartupButton()
        {
            if (Properties.Settings.Default
                .StartupEnabled)
            {
                btnStartup.Text =
                    "Disable Startup";
            }
            else
            {
                btnStartup.Text =
                    "Enable Startup";
            }
        }

        private void RefreshTaskList()
        {
            dgvTasks.Rows.Clear();
            monthCalendar1.RemoveAllBoldedDates();
            lblTaskStats.Text = $"Tasks: {tasks.Count}";

            int completed = tasks.FindAll(
                    t => t.Status == "Completed")
                .Count;

            int missed =
                tasks.FindAll(
                    t => t.Status == "Missed")
                .Count;

            lblTaskStats.Text =
                $"Tasks: {tasks.Count} | " +
                $"Completed: {completed} | " +
                $"Missed: {missed}";

            if (dgvTasks.AllowUserToAddRows)
            {
                int emptyRowIndex =
                    dgvTasks.Rows.Count - 1;

                dgvTasks.ClearSelection();

                dgvTasks.CurrentCell =
                    dgvTasks.Rows[emptyRowIndex]
                    .Cells[0];
            }

            tasks.Sort((a, b) =>
            {
                int priorityA =
                    GetPriorityValue(a.Priority);

                int priorityB =
                    GetPriorityValue(b.Priority);

                return priorityA.CompareTo(priorityB);
            });

            foreach (var task in tasks)
            {
                int rowIndex = dgvTasks.Rows.Add(
                dgvTasks.Rows.Count,
                task.Priority,
                task.Status,
                task.Title,
                task.Deadline);
                monthCalendar1.AddBoldedDate(task.Deadline.Date);

                DataGridViewRow row =
                    dgvTasks.Rows[rowIndex];

                ApplyRowColor(row, task);

                if (task.Status == "Completed")
                {
                    row.DefaultCellStyle.BackColor =
                        Color.LightGray;

                    row.DefaultCellStyle.ForeColor =
                        Color.DarkGray;
                }

                else if (task.Status == "Missed")
                {
                    row.DefaultCellStyle.BackColor =
                        Color.DarkRed;

                    row.DefaultCellStyle.ForeColor =
                        Color.White;
                }

                else
                {
                    switch (task.Priority)
                    {
                        case "High":

                            if (task.Difficulty == "Hard")
                            {
                                row.DefaultCellStyle.BackColor =
                                    Color.IndianRed;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor =
                                    Color.LightCoral;
                            }

                            break;

                        case "Medium":

                            row.DefaultCellStyle.BackColor =
                                Color.Khaki;

                            break;

                        case "Low":

                            row.DefaultCellStyle.BackColor =
                                Color.LightGreen;

                            break;
                    }
                }
            }
        }

        private void ApplyRowColor(
    DataGridViewRow row,
    TaskItem task)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = Color.White;
                cell.Style.ForeColor = Color.Black;
            }

            row.DefaultCellStyle.BackColor =
                Color.White;

            row.DefaultCellStyle.ForeColor =
                Color.Black;

            DataGridViewCell priorityCell =
                row.Cells[1];

            switch (task.Priority)
            {
                case "High":

                    priorityCell.Style.BackColor =
                        Color.IndianRed;

                    priorityCell.Style.ForeColor =
                        Color.White;

                    break;

                case "Medium":

                    priorityCell.Style.BackColor =
                        Color.Khaki;

                    priorityCell.Style.ForeColor =
                        Color.Black;

                    break;

                case "Low":

                    priorityCell.Style.BackColor =
                        Color.LightGreen;

                    priorityCell.Style.ForeColor =
                        Color.Black;

                    break;
            }

            if (task.Status == "Completed")
            {
                row.Cells[2].Style.BackColor =
                    Color.LightGray;

                row.Cells[2].Style.ForeColor =
                        Color.Black;
                    }

                    else if (task.Status == "Missed")
            {
                row.Cells[2].Style.BackColor =
                    Color.DarkRed;

                row.Cells[2].Style.ForeColor =
                    Color.White;
            }
        }

        private int GetPriorityValue(string priority)
        {
            switch (priority)
            {
                case "High":
                    return 1;

                case "Medium":
                    return 2;

                case "Low":
                    return 3;

                default:
                    return 4;
            }
        }

        private void ReminderTimer_Tick(
    object sender,
    EventArgs e)
        {
            foreach (var task in tasks)
            {
                task.Priority =
                    PriorityService.CalculatePriority(task);

                if (task.Deadline < DateTime.Now &&
                    task.Status != "Completed")
                {
                    task.Status = "Missed";
                }
            }

            ReminderService.CheckDeadlines(tasks);

            RefreshTaskList();

            TaskStorageService.SaveTasks(tasks);
        }

        private void btnOpenTaskForm_Click(object sender, EventArgs e)
        {
            TaskForm form = new TaskForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(form.CreatedTask);

                TaskStorageService.SaveTasks(tasks);

                RefreshTaskList();
            }
        }

        private void btnDeleteTask_Click(
        object sender,
        EventArgs e)
        {
            try
            {
                if (dgvTasks.SelectedRows.Count > 0)
                {
                    int selectedIndex =
                        dgvTasks.SelectedRows[0].Index;

                    if (selectedIndex >= 0 &&
                        selectedIndex < tasks.Count)
                    {
                        tasks.RemoveAt(selectedIndex);

                        TaskStorageService.SaveTasks(tasks);

                        RefreshTaskList();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Please select a task.");
                }
            }
            catch
            {
                MessageBox.Show(
                    "Unable to delete task.");
            }
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            ThemeService.ToggleTheme(this);
        }

        private void dgvTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TaskItem selectedTask =
                    tasks[e.RowIndex];

                TaskForm form =
                    new TaskForm(selectedTask);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    TaskStorageService.SaveTasks(tasks);

                    RefreshTaskList();

                }
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                int selectedIndex =
                    dgvTasks.SelectedRows[0].Index;

                tasks[selectedIndex].Status =
                    "Completed";

                TaskStorageService.SaveTasks(tasks);

                RefreshTaskList();
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgvTasks.Rows.Clear();

            foreach (var task in tasks)
            {
                if (task.Deadline.Date ==
                    e.Start.Date)
                {
                    int rowIndex =
                        dgvTasks.Rows.Add(
                            dgvTasks.Rows.Count,
                            task.Priority,
                            task.Status,
                            task.Title,
                            task.Deadline);

                    DataGridViewRow row =
                        dgvTasks.Rows[rowIndex];

                    ApplyRowColor(row, task);
                }
            }
        }

        private void btnStartup_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default
        .StartupEnabled)
            {
                StartupService.DisableStartup();

                Properties.Settings.Default
                    .StartupEnabled = false;
            }
            else
            {
                StartupService.EnableStartup();

                Properties.Settings.Default
                    .StartupEnabled = true;
            }

            Properties.Settings.Default.Save();

            UpdateStartupButton();
        }

        private void rtbNotes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NoteService.SaveNotes(
                    rtbNotes.Text);
            }
            catch
            {

            }
        }
    }
}