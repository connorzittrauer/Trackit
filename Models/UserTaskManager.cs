using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackit.Models
{
    public class UserTaskManager
    {
        public List<UserTask> TaskList { get; private set; }

        public UserTaskManager() 
        { 
            TaskList = new List<UserTask>();

            // Subscribes to the the TaskCreated event in the Task Class 
            UserTask.TaskCreated += AddTask;

       
        }

        public void AddTask(UserTask task)
        {
            TaskList.Add(task);

            //Output to debug console to ensure task is created
           
            //Debug.WriteLine($"Task '{task.TaskName}' added to the Task Manager.");
        }

        public void RemoveTask(UserTask task)
        {
            TaskList.Remove(task);
           
            //Debug.WriteLine($"Task '{task.TaskName}' removed from the Task Manager.");
        }

        // Helper method for printing task list
        public void PrintTasks()
        {
            foreach (var task in TaskList)
            {
                Debug.WriteLine(task);
            }
        }
    }
}
