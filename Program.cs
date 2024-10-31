using System.Diagnostics;
using Trackit.Forms;
using Trackit.Data_Access;
namespace Trackit
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            // Test DB connection here
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.TestDatabaseConnection();

            // Show the LoginForm as a modal dialog first
            using (LoginForm loginForm = new LoginForm()) 
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Launch application if login was successful
                    Application.Run(new MainForm());                
                }
            }
        }
    }
}