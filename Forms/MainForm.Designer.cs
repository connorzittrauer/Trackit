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
            menuStrip1 = new MenuStrip();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            pomodoroToolStripMenuItem = new ToolStripMenuItem();
            taskListview = new ListView();
            colTaskName = new ColumnHeader();
            colTaskDescription = new ColumnHeader();
            colDateCreated = new ColumnHeader();
            colDueDate = new ColumnHeader();
            btnAddTask = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.Items.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, settingsToolStripMenuItem, pomodoroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(715, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(57, 20);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tasksToolStripMenuItem, historyToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(46, 20);
            settingsToolStripMenuItem.Text = "Tasks";
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(121, 22);
            tasksToolStripMenuItem.Text = "Todo List";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(121, 22);
            historyToolStripMenuItem.Text = "History";
            // 
            // pomodoroToolStripMenuItem
            // 
            pomodoroToolStripMenuItem.Name = "pomodoroToolStripMenuItem";
            pomodoroToolStripMenuItem.Size = new Size(76, 20);
            pomodoroToolStripMenuItem.Text = "Pomodoro";
            // 
            // taskListview
            // 
            taskListview.Columns.AddRange(new ColumnHeader[] { colTaskName, colTaskDescription, colDateCreated, colDueDate });
            taskListview.FullRowSelect = true;
            taskListview.Location = new Point(12, 27);
            taskListview.Name = "taskListview";
            taskListview.Size = new Size(691, 276);
            taskListview.TabIndex = 4;
            taskListview.UseCompatibleStateImageBehavior = false;
            taskListview.View = View.Details;
            taskListview.ItemActivate += taskListview_ItemActivate;
            // 
            // colTaskName
            // 
            colTaskName.Text = "Task";
            // 
            // colTaskDescription
            // 
            colTaskDescription.Text = "Task Description";
            colTaskDescription.Width = 150;
            // 
            // colDateCreated
            // 
            colDateCreated.Text = "Date Created";
            colDateCreated.Width = 100;
            // 
            // colDueDate
            // 
            colDueDate.Text = "Due Date";
            colDueDate.Width = 200;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(338, 320);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(75, 23);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(715, 368);
            Controls.Add(btnAddTask);
            Controls.Add(taskListview);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Task Page";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ListView taskListview;
        private ColumnHeader colTaskName;
        private ColumnHeader colTaskDescription;
        private Button btnAddTask;
        private ColumnHeader colDateCreated;
        private ColumnHeader colDueDate;
        private ToolStripMenuItem pomodoroToolStripMenuItem;
    }
}
