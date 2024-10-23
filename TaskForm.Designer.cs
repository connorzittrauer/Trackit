using System.Diagnostics;

namespace Trackit
{
    partial class TaskForm
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
            createTaskButton = new Button();
            taskListView = new ListView();
            taskName = new ColumnHeader();
            taskDescription = new ColumnHeader();
            taskDueDate = new ColumnHeader();
            SuspendLayout();
            // 
            // createTaskButton
            // 
            createTaskButton.Location = new Point(314, 397);
            createTaskButton.Name = "createTaskButton";
            createTaskButton.Size = new Size(133, 46);
            createTaskButton.TabIndex = 0;
            createTaskButton.Text = "Create New Task";
            createTaskButton.UseVisualStyleBackColor = true;
            createTaskButton.Click += createTaskButton_Click;
            // 
            // taskListView
            // 
            taskListView.Columns.AddRange(new ColumnHeader[] { taskName, taskDescription, taskDueDate });
            taskListView.Location = new Point(161, 125);
            taskListView.Name = "taskListView";
            taskListView.Size = new Size(374, 97);
            taskListView.TabIndex = 1;
            taskListView.UseCompatibleStateImageBehavior = false;
            taskListView.View = View.Details;
            taskListView.SelectedIndexChanged += taskListView_SelectedIndexChanged;
            // 
            // taskName
            // 
            taskName.Text = "Task";
            // 
            // taskDescription
            // 
            taskDescription.Text = "Description";
            // 
            // taskDueDate
            // 
            taskDueDate.Text = "Due Date";
            // 
            // TaskPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 538);
            Controls.Add(taskListView);
            Controls.Add(createTaskButton);
            Name = "TaskPage";
            Text = "Task Page";
            ResumeLayout(false);
        }

        #endregion

        private Button createTaskButton;
        private ListView taskListView;
        private ColumnHeader taskName;
        private ColumnHeader taskDescription;
        private ColumnHeader taskDueDate;
    }
}
