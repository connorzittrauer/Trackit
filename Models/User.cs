namespace Trackit.Models
{
    /// <summary>
    /// Model class that represent a User in the Trackit application. 
    /// This class maps to the AppUser table in the database.
    /// 
    /// The UserID property corresponds to the primary key in the database.
    /// </summary>

    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }
    }

}
