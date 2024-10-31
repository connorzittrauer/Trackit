using System.Diagnostics;
using Trackit.Forms;
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

            // Need to run a login form here first 
            Application.Run(new LoginForm());
            Application.Run(new MainForm());  

        }
    }
}