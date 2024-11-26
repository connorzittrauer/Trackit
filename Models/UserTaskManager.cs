using System.Diagnostics;
using Trackit.Data_Access;

namespace Trackit.Models
{
    /// <summary>
    /// UserTaskManager is a singleton class responsible for managing tasks 
    /// associated with the currently logged-in user.
    /// 
    /// It provides a single globally instance that maintains an 
    /// in-memory list of tasks and synchronizes task data with the SQL database.
    /// 
    /// </summary>

    public class UserTaskManager
    {

        private static UserTaskManager _instance;

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

        public List<UserTask> TaskList { get; private set; }

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