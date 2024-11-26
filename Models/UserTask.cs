namespace Trackit.Models
{
    /// <summary>
    /// Model class that represent sa Task associated with a specific user in the application.
    /// Maps to the Task table in the database. 
    /// 
    /// This class provides constructors for both parameterless instantiation and  task creation. 
    /// It also includes an override for the ToString method to provide a readable representation of the task.
    /// </summary>
    /// 

    public class UserTask
    {

        public int TaskID { get; set; }
        public int UserID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool IsCompleted { get; set; }

        public UserTask()
        {
            DateCreated = DateTime.Now;
        }

        public UserTask(int userId, string taskName, string taskDescription, DateTime? dueDate)
        {
            UserID = userId;
            TaskName = taskName;
            TaskDescription = taskDescription;
            DueDate = dueDate;
            DateCreated = DateTime.Now;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"Task ID: {TaskID}, Name: {TaskName}, Description: {TaskDescription}, " +
                   $"Date Created: {DateCreated:g}, Due Date: {DueDate:g}, " +
                   $"Date Completed: {DateCompleted:g}, Is Completed: {IsCompleted}";
        }

    }
}
