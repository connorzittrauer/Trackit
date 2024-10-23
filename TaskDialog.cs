using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackit
{
    public partial class TaskDialog : Form
    {
        public TaskDialog()
        {
            InitializeComponent();
            formatDateTimePicker();
        }

        public void formatDateTimePicker()
        {
            // Set the custom format to display date and time (hour only)
           dateTimePickerDueDate.CustomFormat = "MM/dd/yyyy hh:mm tt"; 

        }


    }
}
