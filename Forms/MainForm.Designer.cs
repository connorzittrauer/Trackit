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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(283, 391);
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
            flowLayoutPanelTasks.Location = new Point(190, 59);
            flowLayoutPanelTasks.Name = "flowLayoutPanelTasks";
            flowLayoutPanelTasks.Size = new Size(329, 316);
            flowLayoutPanelTasks.TabIndex = 1;
            flowLayoutPanelTasks.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 20);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 2;
            label1.Text = "Todo List";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 491);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelTasks);
            Controls.Add(btnAddTask);
            Name = "MainForm";
            Text = "Task Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddTask;
        private FlowLayoutPanel flowLayoutPanelTasks;
        private Label label1;
    }
}
