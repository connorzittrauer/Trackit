namespace Trackit.Forms
{
    partial class ViewTaskForm
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
            btnComplete = new Button();
            pnlBackground = new Panel();
            lblDateCreated = new Label();
            lblUiDateCreated = new Label();
            lblDueDate = new Label();
            lblTaskDescription = new Label();
            lblUiTaskName = new Label();
            lblUiDueDate = new Label();
            lblUiDescription = new Label();
            lblTaskName = new Label();
            pnlBackground.SuspendLayout();
            SuspendLayout();
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(142, 246);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(75, 23);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.White;
            pnlBackground.BorderStyle = BorderStyle.FixedSingle;
            pnlBackground.Controls.Add(lblDateCreated);
            pnlBackground.Controls.Add(lblUiDateCreated);
            pnlBackground.Controls.Add(lblDueDate);
            pnlBackground.Controls.Add(lblTaskDescription);
            pnlBackground.Controls.Add(lblUiTaskName);
            pnlBackground.Controls.Add(lblUiDueDate);
            pnlBackground.Controls.Add(lblUiDescription);
            pnlBackground.Controls.Add(lblTaskName);
            pnlBackground.Location = new Point(12, 12);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(348, 228);
            pnlBackground.TabIndex = 4;
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(17, 134);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(72, 15);
            lblDateCreated.TabIndex = 16;
            lblDateCreated.Text = "date created";
            // 
            // lblUiDateCreated
            // 
            lblUiDateCreated.AutoSize = true;
            lblUiDateCreated.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUiDateCreated.Location = new Point(16, 114);
            lblUiDateCreated.Name = "lblUiDateCreated";
            lblUiDateCreated.Size = new Size(81, 15);
            lblUiDateCreated.TabIndex = 15;
            lblUiDateCreated.Text = "Date Created";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(17, 186);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(53, 15);
            lblDueDate.TabIndex = 14;
            lblDueDate.Text = "due date";
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.Location = new Point(17, 86);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(66, 15);
            lblTaskDescription.TabIndex = 13;
            lblTaskDescription.Text = "description";
            // 
            // lblUiTaskName
            // 
            lblUiTaskName.AutoSize = true;
            lblUiTaskName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUiTaskName.Location = new Point(16, 12);
            lblUiTaskName.Name = "lblUiTaskName";
            lblUiTaskName.Size = new Size(70, 15);
            lblUiTaskName.TabIndex = 12;
            lblUiTaskName.Text = "Task Name:";
            // 
            // lblUiDueDate
            // 
            lblUiDueDate.AutoSize = true;
            lblUiDueDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUiDueDate.Location = new Point(17, 162);
            lblUiDueDate.Name = "lblUiDueDate";
            lblUiDueDate.Size = new Size(63, 15);
            lblUiDueDate.TabIndex = 11;
            lblUiDueDate.Text = "Due Date:";
            // 
            // lblUiDescription
            // 
            lblUiDescription.AutoSize = true;
            lblUiDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUiDescription.Location = new Point(16, 61);
            lblUiDescription.Name = "lblUiDescription";
            lblUiDescription.Size = new Size(74, 15);
            lblUiDescription.TabIndex = 10;
            lblUiDescription.Text = "Description:";
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(16, 36);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(61, 15);
            lblTaskName.TabIndex = 9;
            lblTaskName.Text = "task name";
            // 
            // ViewTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 294);
            Controls.Add(pnlBackground);
            Controls.Add(btnComplete);
            Name = "ViewTaskForm";
            Text = "Edit Task";
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnComplete;
        private Panel pnlBackground;
        private Label lblDateCreated;
        private Label lblUiDateCreated;
        private Label lblDueDate;
        private Label lblTaskDescription;
        private Label lblUiTaskName;
        private Label lblUiDueDate;
        private Label lblUiDescription;
        private Label lblTaskName;
    }
}