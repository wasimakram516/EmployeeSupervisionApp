using EmployeeSupervisionApp.Data;
using EmployeeSupervisionApp.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EmployeeSupervisionApp.Controllers
{
    public class LoginController
    {
        private readonly CompanyContext context;

        public LoginController()
        {
            context = new CompanyContext();
        }

        public Employee AuthenticateUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            return context.Employees.FirstOrDefault(e => e.Email == username && e.Password == hashedPassword);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
