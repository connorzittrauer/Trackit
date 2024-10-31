using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

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

        // Inserts a new user into the AppUser table
        public void InsertUser(string username, string password)
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
                    }
                    // Catches a unique contraint error by number when a username already exists
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Username taken. Please choose another.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting user: " + ex.Message);
                    }
                }

            }
        }

        public void TestInsertUsers()
        {
            InsertUser("john_doe", "password123");
            InsertUser("jane_smith", "securepassword");
            InsertUser("alice_wonder", "mysecret");
        }






    }
}
