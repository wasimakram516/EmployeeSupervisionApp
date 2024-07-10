using EmployeeSupervisionApp.Controllers.Global;
using EmployeeSupervisionApp.Controllers;
using EmployeeSupervisionApp.Models;
using EmployeeSupervisionApp.Services;
using EmployeeSupervisionApp.Views.Common;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeSupervisionApp.Views
{
    public partial class Employees : FormWindow, ITranslatable
    {
        private EmployeeController employeeController;
        private int? selectedEmployeeId = null;
        private TranslationService translationService;

        public Employees()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            translationService = new TranslationService(GlobalSettings.LanguageCode);
            ApplyTranslations();
            DisableResetForm();
            LoadEmployees();

            // Populate ComboBoxes with enum values
            ddGender.DataSource = Enum.GetValues(typeof(Gender));
            ddUserType.DataSource = Enum.GetValues(typeof(UserType));
        }

        private void DisableForm()
        {
            Utility.Disable(pnlForm);
        }

        private void DisableResetForm()
        {
            Utility.DisableReset(pnlForm);
        }

        private void EnableForm()
        {
            Utility.Enable(pnlForm);
        }

        private void EnableResetForm()
        {
            Utility.EnableReset(pnlForm);
        }

        public void ApplyTranslations()
        {
            translationService.SetLanguage(GlobalSettings.LanguageCode);

            lblName.Text = translationService.Translate("label_name");
            lblPosition.Text = translationService.Translate("label_position");
            lblDateOfBirth.Text = translationService.Translate("label_date_of_birth");
            lblDateOfJoining.Text = translationService.Translate("label_date_of_joining");
            lblDateOfLeft.Text = translationService.Translate("label_date_of_left");
            lblEmail.Text = translationService.Translate("label_email");
            lblPhoneNumber.Text = translationService.Translate("label_phone_number");
            lblAddress.Text = translationService.Translate("label_address");
            lblDepartment.Text = translationService.Translate("label_department");
            lblGender.Text = translationService.Translate("label_gender");
            lblUserType.Text = translationService.Translate("label_user_type");
            lblIsActive.Text = translationService.Translate("label_is_active");
            lblPassword.Text = translationService.Translate("label_password");
            btnAdd.Text = translationService.Translate("button_add");
            btnEdit.Text = translationService.Translate("button_edit");
            btnSave.Text = translationService.Translate("button_save");
            btnDelete.Text = translationService.Translate("button_delete");
            btnView.Text = translationService.Translate("button_view");
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            EnableResetForm();
            selectedEmployeeId = null;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId != null)
            {
                Utility.Enable(pnlForm);
            }
            else
            {
                Utility.ShowMsg("Please select an employee to edit.", "Error", "Error");
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var employee = new Employee
                {
                    EmployeeId = selectedEmployeeId ?? 0,
                    Name = txtName.Text,
                    Position = txtPosition.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    DateOfJoining = dtpDateOfJoining.Value,
                    DateOfLeft = chkIsActive.Checked ? null : (DateTime?)dtpDateOfLeft.Value,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    Department = txtDepartment.Text,
                    Gender = (Gender)ddGender.SelectedItem,
                    UserType = (UserType)ddUserType.SelectedItem,
                    IsActive = chkIsActive.Checked
                };

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    employee.Password = Utility.HashPassword(txtPassword.Text);
                }
                else if (selectedEmployeeId != null)
                {
                    var existingEmployee = employeeController.GetEmployeeById(selectedEmployeeId.Value);
                    if (existingEmployee != null)
                    {
                        employee.Password = existingEmployee.Password;
                    }
                }

                if (selectedEmployeeId == null)
                {
                    employeeController.AddEmployee(employee);
                }
                else
                {
                    employeeController.UpdateEmployee(employee);
                }

                Utility.ShowMsg("Employee details saved successfully.", "Success", "Success");
                DisableResetForm();
                LoadEmployees();
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            errName.Visible = string.IsNullOrWhiteSpace(txtName.Text);
            errPosition.Visible = string.IsNullOrWhiteSpace(txtPosition.Text);
            errEmail.Visible = string.IsNullOrWhiteSpace(txtEmail.Text);
            errPhoneNumber.Visible = string.IsNullOrWhiteSpace(txtPhoneNumber.Text);
            errAddress.Visible = string.IsNullOrWhiteSpace(txtAddress.Text);
            errDepartment.Visible = string.IsNullOrWhiteSpace(txtDepartment.Text);
            errDateOfBirth.Visible = dtpDateOfBirth.Value == default;
            errDateOfJoining.Visible = dtpDateOfJoining.Value == default;
            errGender.Visible = ddGender.SelectedIndex == -1;
            errUserType.Visible = ddUserType.SelectedIndex == -1;

            if (errName.Visible || errPosition.Visible || errEmail.Visible || errPhoneNumber.Visible || errAddress.Visible ||
                errDepartment.Visible || errDateOfBirth.Visible || errDateOfJoining.Visible || errGender.Visible || errUserType.Visible)
            {
                Utility.ShowMsg("Fields with * are mandatory!", "Error", "Error");
                isValid = false;
            }

            return isValid;
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId != null)
            {
                var dialogResult = Utility.ShowConfirmation("Are you sure you want to delete this employee?", "Confirm Deletion");
                if (dialogResult == DialogResult.Yes)
                {
                    employeeController.DeleteEmployee(selectedEmployeeId.Value);
                    Utility.ShowMsg("Employee deleted successfully.", "Success", "Success");
                    DisableResetForm();
                    LoadEmployees();
                }
            }
            else
            {
                Utility.ShowMsg("Please select an employee to delete.", "Error", "Error");
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            var employees = employeeController.SearchEmployees(searchText);
            dataGV.DataSource = employees;
        }

        private void LoadEmployees()
        {
            var employees = employeeController.GetAllEmployees();
            dataGV.DataSource = employees;
        }

        public override void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGV.Rows[e.RowIndex];
                DisableForm();

                selectedEmployeeId = row.Cells["EmployeeId"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["EmployeeId"].Value) : (int?)null;
                txtName.Text = row.Cells["Name"].Value?.ToString();
                ddGender.SelectedItem = Enum.TryParse(typeof(Gender), row.Cells["Gender"].Value?.ToString(), out var gender) ? (Gender)gender : Gender.Male;
                dtpDateOfBirth.Value = row.Cells["DateOfBirth"].Value != DBNull.Value ? (DateTime)row.Cells["DateOfBirth"].Value : DateTime.Today;
                ddUserType.SelectedItem = Enum.TryParse(typeof(UserType), row.Cells["UserType"].Value?.ToString(), out var userType) ? (UserType)userType : UserType.Admin;
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                txtPosition.Text = row.Cells["Position"].Value?.ToString();
                txtDepartment.Text = row.Cells["Department"].Value?.ToString();
                dtpDateOfJoining.Value = row.Cells["DateOfJoining"].Value != DBNull.Value ? (DateTime)row.Cells["DateOfJoining"].Value : DateTime.Today;

                if (row.Cells["DateOfLeft"].Value == DBNull.Value || row.Cells["DateOfLeft"].Value == null)
                {
                    dtpDateOfLeft.Value = DateTime.Today;
                }
                else
                {
                    dtpDateOfLeft.Value = (DateTime)row.Cells["DateOfLeft"].Value;
                }

                chkIsActive.Checked = row.Cells["IsActive"].Value != DBNull.Value && (bool)row.Cells["IsActive"].Value;
            }
        }
    }
}
