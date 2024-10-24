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

        private void btnAddTask_Click(object sender, EventArgs e)
        {

            /* Launch Task Dialog 
             * The 'this' keyword is passed to TaskDialog so that has
             * access to all of MainForms UI components.
             */
            TaskDialogForm taskDialogForm = new TaskDialogForm(this);
            taskDialogForm.ShowDialog();

        }
        // THERE IS POSSIBLY A BUG HERE!
        public void PopulateListView()
        {
            // Clear existing items to avoid dupes
            taskListView.Items.Clear();

            foreach (var task in taskList)
            {
                ListViewItem item = new ListViewItem(task.TaskName);

                item.SubItems.Add(task.TaskDescription);
                item.SubItems.Add(task.DueDate?.ToString("MM/dd/yyyy hh:mm tt") ?? "N/A");
                taskListView.Items.Add(item);
            }

        }

        private void taskListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
