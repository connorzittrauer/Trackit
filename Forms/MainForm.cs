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
        }

        private void UpdateListView()
        {
            
            // Clear existing items to avoid dupes
            taskListview.Items.Clear();

            // Add tasks to ListView columns 
            foreach (var task in UserTaskManager.Instance.TaskList)
            {
                ListViewItem item = new ListViewItem(task.TaskName);

                item.SubItems.Add(task.TaskDescription);
                item.SubItems.Add(task.DateCreated?.ToString("MM/dd/yyyy") ?? "N/A");
                item.SubItems.Add(task.DueDate?.ToString("MM/dd/yyyy hh:mm tt") ?? "N/A");

                // Embedded metadata tag TaskId to make removal process easier
                item.Tag = task.TaskID; ;

                taskListview.Items.Add(item);

            }

            // Print list for debugging purposes 
            UserTaskManager.Instance.PrintTasks();

        }

  

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Launch Task Dialog 
            AddTaskForm taskDialogForm = new AddTaskForm();
            taskDialogForm.ShowDialog();

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
                
                int taskId = (int)selectedItem.Tag; 


                /* Uses LINQ and a lambda expression to search and match the internal UserTaskManager TaskList TaskID
                 * to the currently selected ListView taskId and return the Task Object.
                 * 
                 * This enables us to pass easily pass a Task to EditTaskForm() and to view its details and remove it from the list.    
                 */
                UserTask selectedTask = UserTaskManager.Instance.TaskList.FirstOrDefault(task => task.TaskID == taskId);
                
                //Debug.WriteLine(selectedTask.ToString());


                if (selectedTask != null)
                {
                    // Launch EditTaskForm 
                    ViewTaskForm editTaskForm = new ViewTaskForm(selectedTask);
                    if (editTaskForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh ListView items
                        UpdateListView();
                    }
                }
                
            }
        }
    }
}