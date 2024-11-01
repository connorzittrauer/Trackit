using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using Trackit.Models;

namespace Trackit.Data_Access
{

    public class DatabaseManager
    {
        // Retrieves the connection string from App.config
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["TrackitDB"].ConnectionString;
        }
        public void TestDatabaseConnection()
        {
            string connectionString = "Data Source=DESKTOP-33QRJKC\\SQLEXPRESS;Initial Catalog=TrackitDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Debug.WriteLine("Database connection success!");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Database connection failed: " + ex.Message);
                }
            }
        }

        /* 
         * Inserts a new user into the AppUser table
         * Returns a bool for ease of validation/input checking outside of this class. 
         */
        public User InsertUser(string username, string password)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO AppUser (Username, Password) VALUES (@Username, @Password);
                       SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();
                        int newUserId = Convert.ToInt32(result);

                        Debug.WriteLine($"{1} row(s) inserted with UserID: {newUserId}");

                        // Create a new User object with the inserted data
                        User user = new User
                        {
                            UserID = newUserId,
                            UserName = username,
                            Password = password
                        };
                        return user; // Return the newly created user
                    }
                    // Catches a unique constraint error by number if a username already exists
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Username taken. Please choose another.");
                        return null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting user: " + ex.Message);
                        return null;
                    }
                }
            }
        }

        public bool AddTask(UserTask task)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
                             VALUES (@UserID, @TaskName, @TaskDescription, @DateCreated, @DueDate, @DateCompleted, @IsCompleted);
                             SELECT SCOPE_IDENTITY();"; // Returns the last inserted ID

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", task.UserID);
                    cmd.Parameters.AddWithValue("@TaskName", task.TaskName);
                    cmd.Parameters.AddWithValue("@TaskDescription", task.TaskDescription);
                    cmd.Parameters.AddWithValue("@DateCreated", task.DateCreated);
                    cmd.Parameters.AddWithValue("@DueDate", (object)task.DueDate);
                    cmd.Parameters.AddWithValue("@DateCompleted", (object)task.DateCompleted ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);

                    try
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();
                        int newTaskId = Convert.ToInt32(result);
                        task.TaskID = newTaskId;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error adding task: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool UpdateTask(UserTask task)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE Task
                       SET TaskName = @TaskName,
                           TaskDescription = @TaskDescription,
                           DueDate = @DueDate,
                           DateCompleted = @DateCompleted,
                           IsCompleted = @IsCompleted
                       WHERE TaskID = @TaskID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
                    cmd.Parameters.AddWithValue("@TaskName", task.TaskName);
                    cmd.Parameters.AddWithValue("@TaskDescription", task.TaskDescription);
                    cmd.Parameters.AddWithValue("@DueDate", (object)task.DueDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateCompleted", (object)task.DateCompleted ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating task: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public List<UserTask> GetTasksByUserID(int userId)
        {
            List<UserTask> tasks = new List<UserTask>();
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT TaskID, UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted
                             FROM Task
                             WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserTask task = new UserTask
                                {
                                    TaskID = Convert.ToInt32(reader["TaskID"]),
                                    UserID = Convert.ToInt32(reader["UserID"]),
                                    TaskName = reader["TaskName"].ToString(),
                                    TaskDescription = reader["TaskDescription"].ToString(),
                                    DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                                    DueDate = reader["DueDate"] as DateTime?,
                                    DateCompleted = reader["DateCompleted"] as DateTime?,
                                    IsCompleted = Convert.ToBoolean(reader["IsCompleted"])
                                };
                                tasks.Add(task);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving tasks: " + ex.Message);
                    }
                }
            }
            return tasks;
        }

        // Searches for a user by username in the database,
        // if found returns User object, returns null if not found. 
        public User GetUserByUsername(string username)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                string sql = "SELECT UserID, Username, Password FROM AppUser WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(sql, connection)) 
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // User found by username, create a User object
                                User user = new User
                                {
                                    UserID = Convert.ToInt32(reader["UserID"]),
                                    UserName = reader["Username"].ToString(),
                                    Password = reader["Password"].ToString()
                                };
                                return user;
                            }
                            else
                            {
                                // User not found 
                                return null;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving user: " + ex.Message);
                        return null;
                    }
                }

            }
        }
    }
}
