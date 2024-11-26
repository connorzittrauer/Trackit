namespace Trackit.Models
{
    /// <summary>
    /// A static class that manages the current User Session in the Trackit application.
    ///
    /// It simplifies code by avoiding the need to pass the current user object manually to other classes or forms.
    /// </summary>

    public static class SessionManager
    {
        public static User CurrentUser { get; set; }
    }
}
