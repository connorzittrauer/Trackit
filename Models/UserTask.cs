using System;

namespace Trackit.Models
{
    public class UserTask
    {
        public int TaskID { get; set; }        // Now settable
        public int UserID { get; set; }        // Associate task with a user
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool IsCompleted { get; set; }

        // Parameterless constructor
        public UserTask()
        {
            DateCreated = DateTime.Now;
        }

        // Constructor with parameters
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
