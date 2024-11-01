using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trackit.Data_Access;

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
        }

        // Load task from the database for the current user
        public void LoadTasks()
        {
            // If the current user has tasks, load them in
            if (SessionManager.CurrentUser != null)
            {
                DatabaseManager databaseManager = new DatabaseManager();
                TaskList = databaseManager.GetTasksByUserID(SessionManager.CurrentUser.UserID);
            }
            else
            {
                TaskList.Clear();
            }
        }

      
        public void AddTask(UserTask task)
        {
            DatabaseManager databaseManager = new DatabaseManager();
            bool isAdded = new DatabaseManager().AddTask(task);

            if (isAdded)
            {
                TaskList.Add(task);
            }
        }

        public void UpdateTask(UserTask task)
        {
            DatabaseManager databaseManager = new DatabaseManager();
            bool isUpdated = databaseManager.UpdateTask(task);

            if (isUpdated)
            {
                LoadTasks();
            }
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