using Trackit.Forms;
using Trackit.Models;

namespace Trackit
{
    /// <summary>
    /// The main interface of the Trackit application, responsible for displaying and managing tasks.
    /// 
    /// Serves as main portal for task management:
    /// - Viewing tasks (with options to filter between "To-Do" and "All" tasks)
    /// - Adding new tasks 
    /// - Viewing and tasks through a double-click.
    /// - Logging out, which clears the current user session.
    /// 
    /// The form dynamically updates the task list based on changes to the task data. 
    /// </summary>

    public partial class MainForm : Form
    {
        // Default to only showing "Todo" tasks 
        private bool showAllTasks = false;
        public MainForm()
        {
            InitializeComponent();
            UserTaskManager.Instance.LoadTasks();
            UpdateListView();
        }

        private void UpdateListView()
        {

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

            // This populates the TaskList component with the Current user's tasks.
            foreach (var task in tasksToDisplay)
            {
                ListViewItem item = new ListViewItem(task.TaskName);

                item.SubItems.Add(task.TaskDescription);
                item.SubItems.Add(task.DateCreated.ToString("MM/dd/yyyy"));
                item.SubItems.Add(task.DueDate?.ToString("MM/dd/yyyy hh:mm tt"));
                item.SubItems.Add(task.IsCompleted ? "Yes" : "No");

                if (task.IsCompleted)
                {
                    item.ForeColor = Color.DarkGray;
                }

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

        private void taskListview_ItemActivate(object sender, EventArgs e)
        {

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

        // Logs out CurrentUser
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
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