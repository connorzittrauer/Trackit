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
            lblDateCreated.Text = selectedTask.DateCreated.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            selectedTask.IsCompleted = true;
            selectedTask.DateCompleted = DateTime.Now;
            
            // UpdateTask in database and internal TaskList
            UserTaskManager.Instance.UpdateTask(selectedTask);

            // Notify MainForm of succeful removal by setting DialogResult 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
