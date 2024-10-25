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
    }
}