using System.Diagnostics;
using Trackit.Models;

namespace Trackit
{
    public partial class MainForm : Form
    {
        List<UserTask> taskList = UserTaskManager.Instance.TaskList;
        public MainForm()
        {
            InitializeComponent();
        }



        private void PopulateListView()
        {
            // Clear existing items to avoid dupes
            taskListview.Items.Clear();

            foreach (var task in taskList)
            {
                ListViewItem item = new ListViewItem(task.TaskName);

                item.SubItems.Add(task.TaskDescription);
                item.SubItems.Add(task.DateCreated?.ToString("MM/dd ") ?? "N/A");
                item.SubItems.Add(task.DueDate?.ToString("MM/dd/yyyy hh:mm tt") ?? "N/A");
                taskListview.Items.Add(item);

            }

        }

        private void taskListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Launch Task Dialog 
            TaskDialogForm taskDialogForm = new TaskDialogForm();
            taskDialogForm.ShowDialog();

            PopulateListView();
        }

        // Occurs when an item is clicked
        private void taskListview_ItemActivate(object sender, EventArgs e)
        {
            // Check if there is at least one selected item
            if (taskListview.SelectedItems.Count > 0)
            {
                // Get the first selected item
                ListViewItem selectedItem = taskListview.SelectedItems[0];

                // Access the task name (assuming it's in the first column)
                string taskName = selectedItem.SubItems[0].Text;

                // Access other details if needed (e.g., second column for creation date)
                string creationDate = selectedItem.SubItems[1].Text;

                // Debug print the task name and other details
                Debug.WriteLine($"Task Name: {taskName}, Created On: {creationDate}");
            }
        }
    }
}