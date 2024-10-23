using System.Collections;
using System.Diagnostics;

namespace Trackit.Models
{
    public class UserTask
    {
        // Static event to notify subscribers when a task is created
        public static event Action<UserTask> TaskCreated;
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool IsCompleted { get; set; }
        public UserTask(int TaskID, string TaskName, string TaskDescription, DateTime? CreatedDate, DateTime? CompletedDate, DateTime? DueDate, bool IsCompleted)
        {
            this.TaskID = TaskID;
            this.TaskName = TaskName; 
            this.TaskDescription = TaskDescription; 
            this.DateCreated = CreatedDate; 
            this.DateCompleted = CompletedDate; 
            this.DueDate = DueDate;
            this.IsCompleted = IsCompleted;

            // Automatically raise event after task creation
            TaskCreated?.Invoke(this);

        }

        
        public override string ToString()
        {
            // The ?? operator checks if the left-hand side is null. 
            // If it's null, the right-hand side ("N/A") will be returned instead
            return $"Task ID: {TaskID}, Name: {TaskName}, Description: {TaskDescription}, " +
                   $"Date Created: {DateCreated?.ToString("g") ?? "N/A"}, Due Date: {DueDate?.ToString("g") ?? "N/A"}, " +
                   $"Date Completed: {DateCompleted?.ToString("g") ?? "N/A"}, Is Completed: {IsCompleted}";
        }
    }
}
