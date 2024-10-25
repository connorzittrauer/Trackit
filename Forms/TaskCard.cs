using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * A reusable UserControl Task Card component for the FlowLayoutPanel
 * This displays the task details.
*/
namespace Trackit.Forms
{
    public partial class TaskCard : UserControl
    {
        public TaskCard()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get => lblTaskName.Text;
            set => lblTaskName.Text = value;
        }

        public string TaskDescription
        {
            get => lblTaskDesc.Text;
            set => lblTaskDesc.Text = value;
        }

        public string TaskDueDate
        {
            get => lblDueDate.Text;
            set => lblDueDate.Text = value;
        }

        public event EventHandler CompleteButtonClick
        {
            add => btnComplete.Click += value;
            remove => btnComplete.Click -= value;
        }

        private void lblTaskName_Click(object sender, EventArgs e)
        {

        }
    }
}
