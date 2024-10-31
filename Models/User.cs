using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackit.Models
{   

    public class User
    {
        public int UserID { get; set; } // Matches UserID to UserID primary key in the database
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
