using System.Diagnostics;
using Trackit.Forms;
using Trackit.Models;

namespace Trackit
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadTasks()
        {
            // Clear existing controls in the FlowLayoutPanel before adding new ones
            flowLayoutPanelTasks.Controls.Clear();

            // Get the current list of tasks from UserTaskManager
            List<UserTask> taskList = UserTaskManager.Instance.TaskList;

            // Iterate through the task list, add a new card to the flow panel
            foreach (var task in taskList)
            {

                TaskCard taskCard = new TaskCard();

                // Set details for the task card
                taskCard.TaskName = task.TaskName;
                taskCard.TaskDescription = task.TaskDescription;
                taskCard.TaskDueDate = task.DueDate?.ToString("MM/dd/yyyy hh:mm tt") ?? "N/A";

                // Hook up the Complete button event
                taskCard.CompleteButtonClick += (sender, e) => MarkTaskComplete(task);

                flowLayoutPanelTasks.Controls.Add(taskCard);
            }
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Launch Task Dialog Form
            TaskDialogForm taskDialogForm = new TaskDialogForm();

            // This checks that the Dialog Result from the Task DialogForm is OK, before loading all tasks.
            if (taskDialogForm.ShowDialog() == DialogResult.OK)
            {
                // Reload the task list to reflect the newly added task
                LoadTasks();
            }
        }

        private void MarkTaskComplete(UserTask task)
        {
            task.IsCompleted = true;
            MessageBox.Show($"Task '{task.TaskName}' marked complete");

            // TODO: remove task from pane

            // Optionally, reload the completed task list 
            LoadTasks();
        }

    }
}
