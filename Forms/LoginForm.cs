using System.Diagnostics;
using Trackit.Data_Access;
using Trackit.Models;
namespace Trackit.Forms
{
    /// <summary>
    /// Form for user authentication and registration.
    /// 
    /// This form provides two main functions
    /// - Sign In: 
    /// - Sign Up: 
    /// 
    /// Upon successful login or registration, the user's session is set globally using <see cref="SessionManager.CurrentUser"/>.
    /// 
    /// </summary>

    public partial class LoginForm : Form
    {
        string username, password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            username = txtBoxUsername.Text;
            password = txtBoxPassword.Text;

            if (ValidInput(username, password))
            {
                // Retrieve the user signing in from the database
                DatabaseManager databaseManager = new DatabaseManager();
                User user = databaseManager.GetUserByUsername(username);

                if (user != null)
                {
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
                        MessageBox.Show("Incorrect password.");
                        txtBoxPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Username not found. Please sign up.");
                    txtBoxPassword.Clear();
                }

            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            username = txtBoxUsername.Text;
            password = txtBoxPassword.Text;

            // Validate text input fields
            if (ValidInput(username, password))
            {
                // Add new user to database 
                DatabaseManager databaseManager = new DatabaseManager();
                User newUser = databaseManager.InsertUser(username, password);

                // Initializes the CurrentUser session if succesful
                if (newUser != null)
                {
                    SessionManager.CurrentUser = newUser;

                    txtBoxPassword.Clear();
                    txtBoxUsername.Clear();

                    Debug.WriteLine("Current Active User: " + newUser.UserName);

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
