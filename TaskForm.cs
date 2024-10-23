using System.Diagnostics;
using Trackit.Models;

namespace Trackit
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
            Debug.WriteLine("Does this print.");
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            UserTaskManager taskManager = new UserTaskManager();

            //Create a new task from list view fields.


            // Create some tasks
            UserTask task1 = new(1, "Complete Project Report", "Finalize and submit the project report", DateTime.Now, null, DateTime.Now.AddDays(7), false);
            UserTask task2 = new(1, "Complete BIO Lab", "Start preliminary report", DateTime.Now, null, DateTime.Now.AddDays(4), false);
            
            //Debug.WriteLine(task1.ToString());

            // Display all tasks using the task manager
            foreach (var task in taskManager.TaskList)
            {
                Debug.WriteLine(task.ToString());
            }




        }

        private void taskListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
