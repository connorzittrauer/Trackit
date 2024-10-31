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
        public bool InsertUser(string username, string password)
        {
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO AppUser (Username, Password) VALUES (@Username, @Password)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    // Prevents SQL injection with parameter
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Debug.WriteLine($"{rowsAffected} row(s) inserted.");
                        return true; // Insertion successful
                    }
                    // Catches a unique contraint error by number if a username already exists
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Username taken. Please choose another.");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting user: " + ex.Message);
                        return false;
                    }
                }

            }
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
