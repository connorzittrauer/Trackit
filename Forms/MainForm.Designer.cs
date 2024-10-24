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
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(314, 397);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(133, 46);
            btnAddTask.TabIndex = 0;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // flowLayoutPanelTasks
            // 
            flowLayoutPanelTasks.AutoScroll = true;
            flowLayoutPanelTasks.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelTasks.Location = new Point(78, 63);
            flowLayoutPanelTasks.Name = "flowLayoutPanelTasks";
            flowLayoutPanelTasks.Size = new Size(596, 307);
            flowLayoutPanelTasks.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 538);
            Controls.Add(flowLayoutPanelTasks);
            Controls.Add(btnAddTask);
            Name = "MainForm";
            Text = "Task Page";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTask;
        private FlowLayoutPanel flowLayoutPanelTasks;
    }
}
