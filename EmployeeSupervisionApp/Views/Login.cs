using EmployeeSupervisionApp.Controllers;
using EmployeeSupervisionApp.Controllers.Global;
using EmployeeSupervisionApp.Models;
using EmployeeSupervisionApp.Views.Common;
using System;
using System.Windows.Forms;

namespace EmployeeSupervisionApp.Views
{
    public partial class Login : BaseWindow
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            // Hide all error labels initially
            errUsername.Visible = false;
            errPassword.Visible = false;

            // Validate username and password fields
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(username))
            {
                errUsername.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                errPassword.Visible = true;
                isValid = false;
            }

            if (!isValid)
            {
                Utility.ShowMsg("Fields with * are mandatory!", "Error", "Error");
                return;
            }

            LoginController loginController = new LoginController();
            var user = loginController.AuthenticateUser(username, password);

            if (user != null)
            {
                // Store user details in UserSession
                UserSession.EmployeeId = user.EmployeeId;
                UserSession.Name = user.Name;
                UserSession.Email = user.Email;
                UserSession.UserType = user.UserType;

                if (user.UserType == UserType.Admin)
                {
                    Dashboards.dbAdmin adminDashboard = new Dashboards.dbAdmin();
                    Utility.ShowWindow(adminDashboard, this);
                }
                else if (user.UserType == UserType.Employee)
                {
                    Dashboards.dbEmployee employeeDashboard = new Dashboards.dbEmployee();
                    Utility.ShowWindow(employeeDashboard, this);
                }
            }
            else
            {
                Utility.ShowMsg("Invalid username or password", "Un-Authenticated", "Error");
            }
        }
    }
}
