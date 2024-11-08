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
            taskListview = new ListView();
            colTaskName = new ColumnHeader();
            colTaskDescription = new ColumnHeader();
            colDateCreated = new ColumnHeader();
            colDueDate = new ColumnHeader();
            colStatus = new ColumnHeader();
            btnAddTask = new Button();
            settingsMenuStrip = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            viewTodoToolStripMenuItem = new ToolStripMenuItem();
            viewAllToolStripMenuItem = new ToolStripMenuItem();
            settingsMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // taskListview
            // 
            taskListview.Columns.AddRange(new ColumnHeader[] { colTaskName, colTaskDescription, colDateCreated, colDueDate, colStatus });
            taskListview.FullRowSelect = true;
            taskListview.Location = new Point(12, 27);
            taskListview.Name = "taskListview";
            taskListview.Size = new Size(600, 276);
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
            // colStatus
            // 
            colStatus.Text = "Complete";
            colStatus.Width = 100;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(263, 316);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(75, 23);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // settingsMenuStrip
            // 
            settingsMenuStrip.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, viewToolStripMenuItem });
            settingsMenuStrip.Location = new Point(0, 0);
            settingsMenuStrip.Name = "settingsMenuStrip";
            settingsMenuStrip.Size = new Size(630, 24);
            settingsMenuStrip.TabIndex = 6;
            settingsMenuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewTodoToolStripMenuItem, viewAllToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // viewTodoToolStripMenuItem
            // 
            viewTodoToolStripMenuItem.Checked = true;
            viewTodoToolStripMenuItem.CheckState = CheckState.Indeterminate;
            viewTodoToolStripMenuItem.Name = "viewTodoToolStripMenuItem";
            viewTodoToolStripMenuItem.Size = new Size(100, 22);
            viewTodoToolStripMenuItem.Text = "Todo";
            viewTodoToolStripMenuItem.Click += viewTodoToolStripMenuItem_Click;
            // 
            // viewAllToolStripMenuItem
            // 
            viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            viewAllToolStripMenuItem.Size = new Size(100, 22);
            viewAllToolStripMenuItem.Text = "All";
            viewAllToolStripMenuItem.Click += viewAllToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(630, 354);
            Controls.Add(btnAddTask);
            Controls.Add(taskListview);
            Controls.Add(settingsMenuStrip);
            Name = "MainForm";
            Text = "Task Page";
            settingsMenuStrip.ResumeLayout(false);
            settingsMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView taskListview;
        private ColumnHeader colTaskName;
        private ColumnHeader colTaskDescription;
        private Button btnAddTask;
        private ColumnHeader colDateCreated;
        private ColumnHeader colDueDate;
        private MenuStrip settingsMenuStrip;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem viewAllToolStripMenuItem;
        private ToolStripMenuItem viewTodoToolStripMenuItem;
        private ColumnHeader colStatus;
    }
}
