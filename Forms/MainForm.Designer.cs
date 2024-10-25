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
            flowLayoutPanelTasks = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(284, 326);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(133, 32);
            btnAddTask.TabIndex = 0;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // flowLayoutPanelTasks
            // 
            flowLayoutPanelTasks.AutoScroll = true;
            flowLayoutPanelTasks.BackColor = Color.White;
            flowLayoutPanelTasks.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelTasks.Location = new Point(0, 50);
            flowLayoutPanelTasks.Name = "flowLayoutPanelTasks";
            flowLayoutPanelTasks.Size = new Size(715, 270);
            flowLayoutPanelTasks.TabIndex = 1;
            flowLayoutPanelTasks.WrapContents = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.Items.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, settingsToolStripMenuItem });
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
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 32);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 32);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Due Date";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(715, 368);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelTasks);
            Controls.Add(btnAddTask);
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

        private Button btnAddTask;
        private FlowLayoutPanel flowLayoutPanelTasks;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
