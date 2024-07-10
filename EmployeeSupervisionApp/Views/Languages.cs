using EmployeeSupervisionApp.Views.Common;
using EmployeeSupervisionApp.Models;
using EmployeeSupervisionApp.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;
using EmployeeSupervisionApp.Controllers.Global;

namespace EmployeeSupervisionApp.Views
{
    public partial class Languages : FormWindow
    {
        private LanguageController languageController;
        private int? selectedLanguageId = null;

        public Languages()
        {
            InitializeComponent();
            languageController = new LanguageController();
            LoadLanguages();
            DisableResetForm();
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

        private void LoadLanguages()
        {
            var languages = languageController.GetAllLanguages();
            dataGV.DataSource = languages;

            // Set AutoSizeColumnsMode to Fill
            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            EnableResetForm();
            selectedLanguageId = null; // Reset selected language ID for adding new
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedLanguageId != null)
            {
                Utility.Enable(pnlForm); // Enable the form for editing
            }
            else
            {
                Utility.ShowMsg("Please select a language to edit.", "Error", "Error");
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var language = new Language
                {
                    LanguageID = selectedLanguageId ?? 0,
                    LanguageName = txtLanguageName.Text.Trim(),
                    LanguageCode = txtLanguageCode.Text.Trim()
                };

                if (selectedLanguageId == null) // Adding new language
                {
                    languageController.AddLanguage(language);
                }
                else // Updating existing language
                {
                    languageController.UpdateLanguage(language);
                }

                Utility.ShowMsg("Language details saved successfully.", "Success", "Success");
                DisableResetForm();
                LoadLanguages(); // Reload data grid view
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedLanguageId != null)
            {
                var dialogResult = Utility.ShowConfirmation("Are you sure you want to delete this language?", "Confirm Deletion");
                if (dialogResult == DialogResult.Yes)
                {
                    languageController.DeleteLanguage(selectedLanguageId.Value);
                    Utility.ShowMsg("Language deleted successfully.", "Success", "Success");
                    DisableResetForm();
                    LoadLanguages(); // Reload data grid view
                }
            }
            else
            {
                Utility.ShowMsg("Please select a language to delete.", "Error", "Error");
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadLanguages();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            var languages = languageController.SearchLanguages(searchText);
            dataGV.DataSource = languages;
        }

        public override void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGV.Rows[e.RowIndex];
                DisableForm();
                selectedLanguageId = row.Cells["LanguageID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["LanguageID"].Value) : (int?)null;
                txtLanguageName.Text = row.Cells["LanguageName"].Value?.ToString();
                txtLanguageCode.Text = row.Cells["LanguageCode"].Value?.ToString();
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // Validate text fields
            errLanguageName.Visible = string.IsNullOrWhiteSpace(txtLanguageName.Text);
            errLanguageCode.Visible = string.IsNullOrWhiteSpace(txtLanguageCode.Text);

            // Show error message if any validation failed
            if (errLanguageName.Visible || errLanguageCode.Visible)
            {
                Utility.ShowMsg("Fields with * are mandatory!", "Error", "Error");
                isValid = false;
            }

            return isValid;
        }
    }
}
