using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            
                bool isInserted = databaseManager.InsertUser(username, password);

                // Validate SQL database restrictions
                if (isInserted) 
                {
                    txtBoxPassword.Clear();
                    txtBoxUsername.Clear();

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
