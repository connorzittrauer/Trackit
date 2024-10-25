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
            lblDueDate = new Label();
            lblTaskDesc = new Label();
            btnComplete = new Button();
            lblTaskName = new Label();
            SuspendLayout();
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Microsoft New Tai Lue", 9F);
            lblDueDate.Location = new Point(236, 20);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(56, 17);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Due Date";
            // 
            // lblTaskDesc
            // 
            lblTaskDesc.AutoSize = true;
            lblTaskDesc.Font = new Font("Microsoft New Tai Lue", 9F);
            lblTaskDesc.Location = new Point(125, 20);
            lblTaskDesc.Name = "lblTaskDesc";
            lblTaskDesc.Size = new Size(95, 17);
            lblTaskDesc.TabIndex = 2;
            lblTaskDesc.Text = "Task Description";
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(525, 14);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(75, 23);
            btnComplete.TabIndex = 1;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaskName.Location = new Point(3, 15);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(107, 23);
            lblTaskName.TabIndex = 0;
            lblTaskName.Text = "Task Name";
            // 
            // TaskCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblTaskDesc);
            Controls.Add(lblDueDate);
            Controls.Add(lblTaskName);
            Controls.Add(btnComplete);
            Name = "TaskCard";
            Size = new Size(695, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTaskDesc;
        private Button btnComplete;
        private Label lblTaskName;
        private Label lblDueDate;
    }
}
