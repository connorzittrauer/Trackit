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
        // Static field to hold the single instance of UserTaskManager
        private static UserTaskManager _instance;

        // Public property to provide global access to the instance
        public static UserTaskManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserTaskManager();
                }
                return _instance;
            }
        }

        // List to hold tasks
        public List<UserTask> TaskList { get; private set; }

        // Private constructor prevents instantiation from outside the class
        private UserTaskManager()
        {
            TaskList = new List<UserTask>();

            // Subscribes to the TaskCreated event in the UserTask class
            UserTask.TaskCreated += AddTask;
        }

      
        public void AddTask(UserTask task)
        {
            TaskList.Add(task);
            Debug.WriteLine("TASK ADDED: " + task.TaskID + " " + task.TaskName);
        }

        public void RemoveTask(UserTask task)
        {
            TaskList.Remove(task);
            Debug.WriteLine("TASK REMOVED: " + task.TaskID + " " + task.TaskName);
        }

        // Helper debug method for printing task list
        public void PrintTasks()
        {
            Debug.WriteLine("Entire Task List: ");
            foreach (var task in TaskList)
            {
                Debug.WriteLine(task);
            }

        }
    }
}