namespace Trackit.Forms
{
    partial class TaskCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskPanel = new Panel();
            lblDueDate = new Label();
            lblTaskDesc = new Label();
            btnComplete = new Button();
            lblTaskName = new Label();
            taskPanel.SuspendLayout();
            SuspendLayout();
            // 
            // taskPanel
            // 
            taskPanel.BackColor = SystemColors.ControlLight;
            taskPanel.Controls.Add(lblDueDate);
            taskPanel.Controls.Add(lblTaskDesc);
            taskPanel.Controls.Add(btnComplete);
            taskPanel.Controls.Add(lblTaskName);
            taskPanel.Location = new Point(0, 0);
            taskPanel.Name = "taskPanel";
            taskPanel.Size = new Size(297, 177);
            taskPanel.TabIndex = 1;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(3, 0);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 15);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Due Date";
            // 
            // lblTaskDesc
            // 
            lblTaskDesc.AutoSize = true;
            lblTaskDesc.Location = new Point(99, 66);
            lblTaskDesc.Name = "lblTaskDesc";
            lblTaskDesc.Size = new Size(92, 15);
            lblTaskDesc.TabIndex = 2;
            lblTaskDesc.Text = "Task Description";
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(111, 107);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(75, 23);
            btnComplete.TabIndex = 1;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaskName.Location = new Point(94, 29);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(107, 25);
            lblTaskName.TabIndex = 0;
            lblTaskName.Text = "Task Name";
            lblTaskName.Click += lblTaskName_Click;
            // 
            // TaskCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taskPanel);
            Name = "TaskCard";
            Size = new Size(297, 177);
            taskPanel.ResumeLayout(false);
            taskPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel taskPanel;
        private Label lblTaskDesc;
        private Button btnComplete;
        private Label lblTaskName;
        private Label lblDueDate;
    }
}
