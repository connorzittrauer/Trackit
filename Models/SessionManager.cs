using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackit.Models
{   
    /* Static class that manages the current user session
     * 
     * This is for avoidind code duplication and simplicity. Instead of manually passing 
     * the CurrentUser object to class constructors that needs it the CurrentUser object will
     * be available globally.
     * 
     */
    public static class SessionManager
    {
        public static User CurrentUser { get; set; }
    }
}
