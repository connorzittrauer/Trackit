using System.Diagnostics;
using Trackit.Models;

namespace Trackit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            UserTaskManager taskManager = new UserTaskManager();

            // Launch Task Dialog 
            TaskDialogForm taskDialogForm = new TaskDialogForm();
            taskDialogForm.ShowDialog();


        }

        private void taskListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
