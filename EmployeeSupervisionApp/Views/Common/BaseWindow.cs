using EmployeeSupervisionApp.Controllers;
using EmployeeSupervisionApp.Controllers.Global;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeSupervisionApp.Views.Common
{
    public partial class BaseWindow : Form
    {
        public BaseWindow()
        {
            InitializeComponent();

            if (UserSession.EmployeeId != -1) // If User is logged in
            {
                lblUserDetails.Text = UserSession.Name + " (" + UserSession.UserType + ")";
            }
            else
            {
                lblUserDetails.Text = "User";
            }
        }
    }
}
