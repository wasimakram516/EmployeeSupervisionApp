using EmployeeSupervisionApp.Controllers.Global;
using EmployeeSupervisionApp.Views;
using System;
using System.Windows.Forms;

namespace EmployeeSupervisionApp
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            Login loginForm = new Login
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            loginForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSession.EmployeeId != -1)
            {
                var dialogResult = Utility.ShowConfirmation("Are you sure you want to logout?", "Confirm Logout");
                if (dialogResult == DialogResult.Yes)
                {
                    UserSession.Logout();
                    foreach (Form form in this.MdiChildren)
                    {
                        form.Close();
                    }
                    ShowLoginForm();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = Utility.ShowConfirmation("Are you sure you want to exit the application?", "Confirm Exit");
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
