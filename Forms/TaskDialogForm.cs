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
    public partial class TaskDialogForm : Form
    {
        List<UserTask> taskList = UserTaskManager.Instance.TaskList;
        MainForm mainForm;

        public TaskDialogForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            // Set the custom format to display date and time 
            dateTimePickerDueDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            UserTaskManager taskManager = UserTaskManager.Instance;

            string taskName = textBoxTaskName.Text;
            string taskDescription = textBoxTaskDescription.Text;
            DateTime dueDate = dateTimePickerDueDate.Value;

            // Validate user input
            if (!ValidateInput(taskName, taskDescription))
            {
                return;      
            }

            // Capture user input data and create a new task
            UserTask newTask = new UserTask(
                TaskName: taskName,
                TaskDescription: taskDescription,
                CompletedDate: null,
                DueDate: dueDate,
                IsCompleted: false
             );

            // Clear out fields 
            ClearFormFields();

            mainForm.PopulateListView();

            MessageBox.Show($"Successfully added task: {taskName}");

            
        }


        // Helper method to clear form fields
        private void ClearFormFields()
        {
            textBoxTaskName.Clear();
            textBoxTaskDescription.Clear();
            dateTimePickerDueDate.Value = DateTime.Now; // Reset to current date
        }

        // Validates user input and alerts if field is empty 
        private bool ValidateInput(string taskName, string taskDescription)
        {

            if (string.IsNullOrWhiteSpace(taskName))
            {
                MessageBox.Show("Task cannot be empty.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(taskDescription))
            {
                MessageBox.Show("Task description be empty.");
                return false;
            }
           return true;
        }

    }
}

