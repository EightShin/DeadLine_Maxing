using DeadLine_Maxing.Models;
using DeadLine_Maxing.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace DeadLine_Maxing
{
    public partial class TaskForm : Form
    {
        private List<string> attachedFiles =
            new List<string>();

        public TaskItem CreatedTask { get; private set; }

        public TaskForm()
        {
            InitializeComponent();

            txtTitle.Text = "Enter task title...";
            txtDescription.Text = "Enter task details here...";

            ThemeService.ApplyTheme(this);

            InitializeDropdowns();
        }

        public TaskForm(TaskItem existingTask)
        {
            InitializeComponent();

            ThemeService.ApplyTheme(this);

            InitializeDropdowns();

            txtTitle.Text =
                existingTask.Title;

            txtDescription.Text =
                existingTask.Description;

            dtDeadline.Value =
                existingTask.Deadline;

            cmbDifficulty.Text =
                existingTask.Difficulty;

            cmbStatus.Text =
                existingTask.Status;

            attachedFiles =
                existingTask.AttachedFiles;

            foreach (var file in attachedFiles)
            {
                lstAttachments.Items.Add(file);
            }

            CreatedTask = existingTask;
        }

        private void InitializeDropdowns()
        {
            cmbDifficulty.Items.Add("Easy");
            cmbDifficulty.Items.Add("Medium");
            cmbDifficulty.Items.Add("Hard");

            cmbDifficulty.SelectedIndex = 0;

            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Missed");

            cmbStatus.SelectedIndex = 0;
        }

        private void btnSaveTask_Click_1(
            object sender,
            EventArgs e)
        {
            if (CreatedTask == null)
                CreatedTask = new TaskItem();

            CreatedTask.Title =
                txtTitle.Text;

            CreatedTask.Description =
                txtDescription.Text;

            CreatedTask.Deadline =
                dtDeadline.Value;

            CreatedTask.Difficulty =
                cmbDifficulty.Text;

            CreatedTask.Status =
                cmbStatus.Text;

            CreatedTask.AttachedFiles =
                attachedFiles;

            CreatedTask.Priority =
                PriorityService.CalculatePriority(
                    CreatedTask);

            this.DialogResult =
                DialogResult.OK;

            this.Close();
        }

        private void btnAttachFiles_Click(
            object sender,
            EventArgs e)
        {
            List<string> newFiles =
                FileAttachmentService.PickFiles();

            foreach (var file in newFiles)
            {
                if (!attachedFiles.Contains(file))
                {
                    attachedFiles.Add(file);

                    lstAttachments.Items.Add(file);
                }
            }
        }

        private void lstAttachments_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (lstAttachments.SelectedItem != null)
            {
                string selectedFile =
                    lstAttachments.SelectedItem.ToString();

                try
                {
                    Process.Start(selectedFile);
                }
                catch
                {
                    MessageBox.Show(
                        "Unable to open file.");
                }
            }
        }

        private void txtTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtTitle.Text == "Enter task title...")
            {
                txtTitle.Text = "";
            }
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
        txtTitle.Text))
            {
                txtTitle.Text =
                    "Enter task title...";
            }
        }

        private void txtDescription_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtDescription.Text == "Enter task details here...")
            {
                txtDescription.Text = "";
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
        txtDescription.Text))
            {
                txtDescription.Text =
                    "Enter task details here...";
            }
        }
    }
}