using EmployeeSupervisionApp.Models;

namespace EmployeeSupervisionApp.Controllers.Global
{
    public static class UserSession
    {
        static UserSession()
        {
            ResetSession();
        }

        public static int EmployeeId { get; set; }
        public static string Name { get; set; }
        public static string Email { get; set; }
        public static UserType UserType { get; set; }

        public static void Logout()
        {
            ResetSession();
        }

        private static void ResetSession()
        {
            EmployeeId = -1;  // Use -1 to indicate no user is logged in
            Name = string.Empty;
            Email = string.Empty;
            UserType = UserType.Employee; // Default to Employee, you can choose another default
        }
    }
}
