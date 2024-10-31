using System;
using System.Windows.Forms;
using Trackit.Data_Access;
using Trackit.Forms;
using Trackit.Models;

namespace Trackit
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Application loop
            while (true)
            {
                // Show the LoginForm as a modal dialog
                using (LoginForm loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() != DialogResult.OK)
                    {
                        // User did not log in successfully; exit application
                        break;
                    }
                }

                // User logged in successfully; start the main form
                using (MainForm mainForm = new MainForm())
                {
                    DatabaseManager databaseManager = new DatabaseManager();
                    databaseManager.TestDatabaseConnection();

                    Application.Run(mainForm);
                }

                // After MainForm is closed, check if user logged out
                if (SessionManager.CurrentUser == null)
                {
                    // User logged out; loop back to show login form again
                    continue;
                }
                else
                {
                    // User closed MainForm without logging out; exit application
                    break;
                }
            }
        }
    }
}
