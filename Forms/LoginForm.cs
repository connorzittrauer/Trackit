using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trackit.Data_Access;
using Trackit.Models;
namespace Trackit.Forms
{
    public partial class LoginForm : Form
    {
        string username, password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Grab data from TextBox fields
            username = txtBoxUsername.Text;
            password = txtBoxPassword.Text;

            if (ValidInput(username, password))
            {
                // Retrieve the user signing in from the database
                DatabaseManager databaseManager = new DatabaseManager();
                User user = databaseManager.GetUserByUsername(username);

                if (user != null)
                {
                    // User exists, compare passwords
                    if (user.Password == password) 
                    {
                        //Set the global state for currently logged in user
                        SessionManager.CurrentUser = user;

                        Debug.WriteLine("Current Active User: " + user.UserName);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        // Passwords do not match
                        MessageBox.Show("Incorrect password.");
                        txtBoxPassword.Clear();
                    }
                }
                else
                {
                    // User is null, does not exist.
                    MessageBox.Show("Username not found. Please sign up.");
                    txtBoxPassword.Clear();
                }

            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Grab data from TextBox fields
            username = txtBoxUsername.Text;
            password = txtBoxPassword.Text;
         
            // Validate text input fields
            if (ValidInput(username, password))
            {
                // Add new user to database 
                DatabaseManager databaseManager = new DatabaseManager();
            
                User newUser = databaseManager.InsertUser(username, password);

                // Validate SQL database restrictions
                if (newUser != null) 
                {
                    // Sets global state for currently logged in user
                    SessionManager.CurrentUser = newUser;

                    txtBoxPassword.Clear();
                    txtBoxUsername.Clear();

                    Debug.WriteLine("Current Active User: " + newUser.UserName);

                    // Signup was successful 
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                // Signup failed, stay on LoginForm
                else
                {
                    txtBoxUsername.Clear();
                    txtBoxPassword.Clear();
                }
            }
        }

        // Validates user input and alerts if field is empty 
        private bool ValidInput(string username, string password)
        {

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty.");
                return false;
            }
            return true;
        }
    }
}
