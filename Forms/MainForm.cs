using System.Diagnostics;
using Trackit.Models;
using Trackit.Forms;

namespace Trackit
{
    public partial class MainForm : Form
    {
        private bool showAllTasks = false; // Default to showing "To Do" tasks 
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

            // Determine which tasks to display based on flag
            IEnumerable<UserTask> tasksToDisplay;

            if (showAllTasks)
            {
                // Show all tasks
                tasksToDisplay = UserTaskManager.Instance.TaskList;
            }
            else
            {
                // Show To-do list
                tasksToDisplay = UserTaskManager.Instance.TaskList.Where(t => !t.IsCompleted);
            }

            // Add tasks to ListView columns
            foreach (var task in tasksToDisplay)
            {
                ListViewItem item = new ListViewItem(task.TaskName);

                item.SubItems.Add(task.TaskDescription);
                item.SubItems.Add(task.DateCreated.ToString("MM/dd/yyyy"));
                item.SubItems.Add(task.DueDate?.ToString("MM/dd/yyyy hh:mm tt"));
                item.SubItems.Add(task.IsCompleted ? "Yes" : "No");

                if (task.IsCompleted)
                {
                    //item.BackColor = Color.LightGray;
                    item.ForeColor = Color.DarkGray;
                }

                // Store the last object in the Tag property
                item.Tag = task;

                taskListview.Items.Add(item);

            }
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
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear current user
            SessionManager.CurrentUser = null;
            this.Close();
        }

        private void viewTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAllTasks = false;
            viewTodoToolStripMenuItem.CheckState = CheckState.Indeterminate;
            viewAllToolStripMenuItem.CheckState = CheckState.Unchecked;
            UpdateListView();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAllTasks = true;
            viewTodoToolStripMenuItem.CheckState = CheckState.Unchecked;
            viewAllToolStripMenuItem.CheckState = CheckState.Indeterminate;
            UpdateListView();
        }
    }
}