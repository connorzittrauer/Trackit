using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackit.Models
{   

    public class User
    {
        public int UserID { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string username, string password) 
        { 
            this.UserName = username;
            this.Password = password;
        }
    }
}
