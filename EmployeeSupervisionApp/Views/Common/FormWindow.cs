using EmployeeSupervisionApp.Controllers.Global;
using EmployeeSupervisionApp.Models;
using System.ComponentModel;
using System.Windows.Forms;

namespace EmployeeSupervisionApp.Views.Common
{
    public partial class FormWindow : BaseWindow
    {
        public FormWindow()
        {
            if (!IsInDesignMode())
            {
                InitializeComponent();
            }
        }

        public virtual void btnBack_Click(object sender, EventArgs e)
        {
            if (UserSession.UserType == UserType.Admin)
            {
                Dashboards.dbAdmin adminDashboard = new Dashboards.dbAdmin();
                Utility.ShowWindow(adminDashboard, this);
            }
            else if (UserSession.UserType == UserType.Employee)
            {
                Dashboards.dbEmployee employeeDashboard = new Dashboards.dbEmployee();
                Utility.ShowWindow(employeeDashboard, this);
            }
        }

        public virtual void btnAdd_Click(object sender, EventArgs e) { }
        public virtual void btnEdit_Click(object sender, EventArgs e) { }
        public virtual void btnSave_Click(object sender, EventArgs e) { }
        public virtual void btnDelete_Click(object sender, EventArgs e) { }
        public virtual void btnView_Click(object sender, EventArgs e) { }
        public virtual void txtSearch_TextChanged(object sender, EventArgs e) { }
        public virtual void dataGV_CellClick(object sender, DataGridViewCellEventArgs e) { }

        private bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime ||
                   System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv";
        }
    }
}
