using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trackit.Models;

namespace Trackit
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
           
            // Set the custom format to display date and time 
            dateTimePickerDueDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskName = textBoxTaskName.Text;
            string taskDescription = textBoxTaskDescription.Text;
            DateTime dueDate = dateTimePickerDueDate.Value;


            if (!ValidInput(taskName, taskDescription))
            {
                return;
            }

            // Capture user input data and create a new task
            UserTask newTask = new UserTask
            {
                UserID = SessionManager.CurrentUser.UserID,
                TaskName = taskName,
                TaskDescription = taskDescription,
                DueDate = dueDate,
                IsCompleted = false,
                DateCreated = DateTime.Now
            };


            UserTaskManager.Instance.AddTask(newTask);

            ClearFormFields();

            /* 
             * These lines are important to trigger the panes to populate the FlowLayoutPanel.
             * DialogResult.OK indicates the outcome of a from when it is closed,
             * specifying that the dialog box was sucessfully completed.
             * 
             */
            
            this.DialogResult = DialogResult.OK;  //Dialog result automatically closes a MODAL form in Windows Forms
            this.Close();  // This will trigger MainForm to load tasks!
        }


        // Helper method to clear form fields
        private void ClearFormFields()
        {
            textBoxTaskName.Clear();
            textBoxTaskDescription.Clear();
            dateTimePickerDueDate.Value = DateTime.Now; // Reset to current date
        }

        // Validates user input and alerts if field is empty 
        private bool ValidInput(string taskName, string taskDescription)
        {

            if (string.IsNullOrWhiteSpace(taskName))
            {
                MessageBox.Show("Task cannot be empty.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(taskDescription))
            {
                MessageBox.Show("Task description cannot be empty.");
                return false;
            }
           return true;
        }

    }
}

