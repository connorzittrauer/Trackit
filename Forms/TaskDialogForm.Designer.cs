
namespace Trackit
{
    partial class TaskDialogForm
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
            textBoxTaskName = new TextBox();
            lblTaskName = new Label();
            lblTaskDescription = new Label();
            textBoxTaskDescription = new RichTextBox();
            lblDueDate = new Label();
            dateTimePickerDueDate = new DateTimePicker();
            btnAddTask = new Button();
            SuspendLayout();
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(121, 33);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new Size(185, 23);
            textBoxTaskName.TabIndex = 0;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(29, 36);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(64, 15);
            lblTaskName.TabIndex = 1;
            lblTaskName.Text = "Task Name";
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.Location = new Point(23, 81);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(92, 15);
            lblTaskDescription.TabIndex = 3;
            lblTaskDescription.Text = "Task Description";
            // 
            // textBoxTaskDescription
            // 
            textBoxTaskDescription.Location = new Point(121, 81);
            textBoxTaskDescription.Name = "textBoxTaskDescription";
            textBoxTaskDescription.Size = new Size(185, 79);
            textBoxTaskDescription.TabIndex = 4;
            textBoxTaskDescription.Text = "";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(29, 179);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 15);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "Due Date";
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDueDate.Location = new Point(121, 179);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(200, 23);
            dateTimePickerDueDate.TabIndex = 6;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(170, 218);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(75, 23);
            btnAddTask.TabIndex = 7;
            btnAddTask.Text = "Add";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // TaskDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 253);
            Controls.Add(btnAddTask);
            Controls.Add(dateTimePickerDueDate);
            Controls.Add(lblDueDate);
            Controls.Add(textBoxTaskDescription);
            Controls.Add(lblTaskDescription);
            Controls.Add(lblTaskName);
            Controls.Add(textBoxTaskName);
            Name = "TaskDialogForm";
            Text = "TaskDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTaskName;
        private Label lblTaskName;
        private Label lblTaskDescription;
        private RichTextBox textBoxTaskDescription;
        private Label lblDueDate;
        private DateTimePicker dateTimePickerDueDate;
        private Button btnAddTask;
    }
}