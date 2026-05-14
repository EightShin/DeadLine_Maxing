namespace DeadLine_Maxing
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.dtDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.btnAttachFiles = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(30, 69);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(157, 23);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            this.txtTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtTitle_MouseDoubleClick);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(30, 280);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 171);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "";
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            this.txtDescription.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtDescription_MouseDoubleClick);
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(30, 117);
            this.cmbDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(157, 23);
            this.cmbDifficulty.TabIndex = 2;
            // 
            // dtDeadline
            // 
            this.dtDeadline.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeadline.Location = new System.Drawing.Point(30, 216);
            this.dtDeadline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtDeadline.Name = "dtDeadline";
            this.dtDeadline.ShowUpDown = true;
            this.dtDeadline.Size = new System.Drawing.Size(157, 23);
            this.dtDeadline.TabIndex = 3;
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveTask.AutoSize = true;
            this.btnSaveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTask.Location = new System.Drawing.Point(388, 472);
            this.btnSaveTask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(88, 27);
            this.btnSaveTask.TabIndex = 4;
            this.btnSaveTask.Text = "Save Task";
            this.btnSaveTask.UseVisualStyleBackColor = true;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click_1);
            // 
            // btnAttachFiles
            // 
            this.btnAttachFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachFiles.Location = new System.Drawing.Point(707, 242);
            this.btnAttachFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAttachFiles.Name = "btnAttachFiles";
            this.btnAttachFiles.Size = new System.Drawing.Size(88, 27);
            this.btnAttachFiles.TabIndex = 5;
            this.btnAttachFiles.Text = "Attach Files";
            this.btnAttachFiles.UseVisualStyleBackColor = true;
            this.btnAttachFiles.Click += new System.EventHandler(this.btnAttachFiles_Click);
            // 
            // lstAttachments
            // 
            this.lstAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.ItemHeight = 15;
            this.lstAttachments.Location = new System.Drawing.Point(558, 67);
            this.lstAttachments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(237, 169);
            this.lstAttachments.TabIndex = 6;
            this.lstAttachments.SelectedIndexChanged += new System.EventHandler(this.lstAttachments_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(30, 167);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(157, 23);
            this.cmbStatus.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Task Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Difficulty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Deadline:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Attachments:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "Task Creation/Edit";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lstAttachments);
            this.Controls.Add(this.btnAttachFiles);
            this.Controls.Add(this.btnSaveTask);
            this.Controls.Add(this.dtDeadline);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.DateTimePicker dtDeadline;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.Button btnAttachFiles;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}