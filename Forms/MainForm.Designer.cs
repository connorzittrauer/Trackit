using System.Diagnostics;

namespace Trackit
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddTask = new Button();
            taskListView = new ListView();
            taskName = new ColumnHeader();
            taskDescription = new ColumnHeader();
            taskDueDate = new ColumnHeader();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(314, 397);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(133, 46);
            btnAddTask.TabIndex = 0;
            btnAddTask.Text = "Create New Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // taskListView
            // 
            taskListView.Columns.AddRange(new ColumnHeader[] { taskName, taskDescription, taskDueDate });
            taskListView.Location = new Point(129, 125);
            taskListView.Name = "taskListView";
            taskListView.Size = new Size(529, 97);
            taskListView.TabIndex = 1;
            taskListView.UseCompatibleStateImageBehavior = false;
            taskListView.View = View.Details;
            taskListView.SelectedIndexChanged += taskListView_SelectedIndexChanged;
            // 
            // taskName
            // 
            taskName.Text = "Task";
            taskName.Width = 100;
            // 
            // taskDescription
            // 
            taskDescription.Text = "Description";
            taskDescription.Width = 150;
            // 
            // taskDueDate
            // 
            taskDueDate.Text = "Due Date";
            taskDueDate.Width = 150;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 538);
            Controls.Add(taskListView);
            Controls.Add(btnAddTask);
            Name = "MainForm";
            Text = "Task Page";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTask;
        private ListView taskListView;
        private ColumnHeader taskName;
        private ColumnHeader taskDescription;
        private ColumnHeader taskDueDate;
    }
}
