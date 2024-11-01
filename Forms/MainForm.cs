using System.Diagnostics;
using Trackit.Models;
using Trackit.Forms;

namespace Trackit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Load tasks from the database
            UserTaskManager.Instance.LoadTasks();
            UpdateListView();
        }

        private void UpdateListView()
        {

            // Clear existing items to avoid dupes
            taskListview.Items.Clear();

            // Add tasks to ListView columns, exclude completed tasks
            foreach (var task in UserTaskManager.Instance.TaskList.Where(t=> !t.IsCompleted))
            {
                ListViewItem item = new ListViewItem(task.TaskName);

                item.SubItems.Add(task.TaskDescription);
                item.SubItems.Add(task.DateCreated.ToString("MM/dd/yyyy"));
                item.SubItems.Add(task.DueDate?.ToString("MM/dd/yyyy hh:mm tt"));

                // Store the last object in the Tag property
                item.Tag = task;

                taskListview.Items.Add(item);

            }

            UserTaskManager.Instance.PrintTasks();

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm taskForm = new AddTaskForm();
            taskForm.ShowDialog();

            UpdateListView();
        }

        // Event triggered when a ListView item is clicked
        private void taskListview_ItemActivate(object sender, EventArgs e)
        {

            // Check if there is at least one selected item
            if (taskListview.SelectedItems.Count > 0)
            {
                // Get the first selected item
                ListViewItem selectedItem = taskListview.SelectedItems[0];

                // Retrieve the task from the Tag property in ListView
                UserTask selectedTask = (UserTask)selectedItem.Tag;

                if (selectedTask != null)
                {
                    // Pass selectedTask to ViewTaskForm
                    ViewTaskForm editTaskForm = new ViewTaskForm(selectedTask);
                    if (editTaskForm.ShowDialog() == DialogResult.OK)
                    {
                        UpdateListView();
                    }
                }

            }
        }
        // Logout functionality
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear current user
            SessionManager.CurrentUser = null;
            this.Close();
        }
    }
}