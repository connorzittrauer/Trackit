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
            lblTaskName = new Label();
            lblUiDescription = new Label();
            lblUiDueDate = new Label();
            btnComplete = new Button();
            lblUiTaskName = new Label();
            lblTaskDescription = new Label();
            lblDueDate = new Label();
            lblUiDateCreated = new Label();
            lblDateCreated = new Label();
            SuspendLayout();
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(12, 43);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(61, 15);
            lblTaskName.TabIndex = 0;
            lblTaskName.Text = "task name";
            // 
            // lblUiDescription
            // 
            lblUiDescription.AutoSize = true;
            lblUiDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUiDescription.Location = new Point(12, 68);
            lblUiDescription.Name = "lblUiDescription";
            lblUiDescription.Size = new Size(74, 15);
            lblUiDescription.TabIndex = 1;
            lblUiDescription.Text = "Description:";
            // 
            // lblUiDueDate
            // 
            lblUiDueDate.AutoSize = true;
            lblUiDueDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUiDueDate.Location = new Point(13, 169);
            lblUiDueDate.Name = "lblUiDueDate";
            lblUiDueDate.Size = new Size(63, 15);
            lblUiDueDate.TabIndex = 2;
            lblUiDueDate.Text = "Due Date:";
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(150, 246);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(75, 23);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // lblUiTaskName
            // 
            lblUiTaskName.AutoSize = true;
            lblUiTaskName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUiTaskName.Location = new Point(12, 19);
            lblUiTaskName.Name = "lblUiTaskName";
            lblUiTaskName.Size = new Size(70, 15);
            lblUiTaskName.TabIndex = 4;
            lblUiTaskName.Text = "Task Name:";
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.Location = new Point(13, 93);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(66, 15);
            lblTaskDescription.TabIndex = 5;
            lblTaskDescription.Text = "description";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(13, 193);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(53, 15);
            lblDueDate.TabIndex = 6;
            lblDueDate.Text = "due date";
            // 
            // lblUiDateCreated
            // 
            lblUiDateCreated.AutoSize = true;
            lblUiDateCreated.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUiDateCreated.Location = new Point(12, 121);
            lblUiDateCreated.Name = "lblUiDateCreated";
            lblUiDateCreated.Size = new Size(81, 15);
            lblUiDateCreated.TabIndex = 7;
            lblUiDateCreated.Text = "Date Created";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(13, 141);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(72, 15);
            lblDateCreated.TabIndex = 8;
            lblDateCreated.Text = "date created";
            // 
            // EditTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 294);
            Controls.Add(lblDateCreated);
            Controls.Add(lblUiDateCreated);
            Controls.Add(lblDueDate);
            Controls.Add(lblTaskDescription);
            Controls.Add(lblUiTaskName);
            Controls.Add(btnComplete);
            Controls.Add(lblUiDueDate);
            Controls.Add(lblUiDescription);
            Controls.Add(lblTaskName);
            Name = "EditTaskForm";
            Text = "Edit Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskName;
        private Label lblUiDescription;
        private Label lblUiDueDate;
        private Button btnComplete;
        private Label lblUiTaskName;
        private Label lblTaskDescription;
        private Label lblDueDate;
        private Label lblUiDateCreated;
        private Label lblDateCreated;
    }
}