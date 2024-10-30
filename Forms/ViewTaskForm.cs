using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trackit.Models;

namespace Trackit.Forms
{
    public partial class ViewTaskForm : Form
    {
        private UserTask selectedTask;
        public ViewTaskForm(UserTask task)
        {
            InitializeComponent();
            this.selectedTask = task;

            // Initialize UI fields
            lblTaskName.Text = selectedTask.TaskName;
            lblTaskDescription.Text = selectedTask.TaskDescription;
            lblDueDate.Text = selectedTask.DueDate?.ToString("MM/dd/yyyy hh:mm tt");
            lblDateCreated.Text = selectedTask.DateCreated?.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            // Remove from internal task list and mark as completed
            //UserTaskManager.Instance.TaskList.Remove(selectedTask);
            
            UserTaskManager.Instance.RemoveTask(selectedTask);
            selectedTask.IsCompleted = true;

            // Notify MainForm of succeful removal by setting DialogResult 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
