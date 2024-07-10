using EmployeeSupervisionApp.Controllers;
using EmployeeSupervisionApp.Controllers.Global;
using EmployeeSupervisionApp.Models;
using EmployeeSupervisionApp.Views.Common;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeSupervisionApp.Views
{
    public partial class Translations : FormWindow
    {
        private TranslationController translationController;
        private LanguageController languageController;
        private ElementKeyController elementKeyController;
        private int? selectedTranslationId = null;

        public Translations()
        {
            InitializeComponent();
            translationController = new TranslationController();
            languageController = new LanguageController();
            elementKeyController = new ElementKeyController();
            DisableResetForm();
            LoadTranslations();
            LoadLanguagesAndKeys();
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

        private void LoadTranslations()
        {
            var translations = translationController.GetAllTranslations();
            dataGV.DataSource = translations.Select(t => new
            {
                t.TranslationID,
                t.ElementKey.Key,
                t.Language.LanguageName,
                t.TranslationText
            }).ToList();

            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadLanguagesAndKeys()
        {
            var languages = languageController.GetAllLanguages();
            ddLanguage.DataSource = languages;
            ddLanguage.DisplayMember = "LanguageName";
            ddLanguage.ValueMember = "LanguageID";

            var elementKeys = elementKeyController.GetAllElementKeys();
            ddElementKey.DataSource = elementKeys;
            ddElementKey.DisplayMember = "Key";
            ddElementKey.ValueMember = "ElementKeyID";
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            EnableResetForm();
            selectedTranslationId = null; // Reset selected translation ID for adding new
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedTranslationId != null)
            {
                Utility.Enable(pnlForm); // Enable the form for editing
            }
            else
            {
                Utility.ShowMsg("Please select a translation to edit.", "Error", "Error");
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var translation = new Translation
                {
                    TranslationID = selectedTranslationId ?? 0,
                    ElementKeyID = (int)ddElementKey.SelectedValue,
                    LanguageID = (int)ddLanguage.SelectedValue,
                    TranslationText = txtTranslationText.Text.Trim()
                };

                translationController.AddOrUpdateTranslation(translation);

                Utility.ShowMsg("Translation saved successfully.", "Success", "Success");
                DisableResetForm();
                LoadTranslations(); // Reload data grid view
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTranslationId != null)
            {
                var dialogResult = Utility.ShowConfirmation("Are you sure you want to delete this translation?", "Confirm Deletion");
                if (dialogResult == DialogResult.Yes)
                {
                    translationController.DeleteTranslation(selectedTranslationId.Value);
                    Utility.ShowMsg("Translation deleted successfully.", "Success", "Success");
                    DisableResetForm();
                    LoadTranslations(); // Reload data grid view
                }
            }
            else
            {
                Utility.ShowMsg("Please select a translation to delete.", "Error", "Error");
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            LoadTranslations();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            var translations = translationController.SearchTranslations(searchText);
            dataGV.DataSource = translations.Select(t => new
            {
                t.TranslationID,
                t.ElementKey.Key,
                t.Language.LanguageName,
                t.TranslationText
            }).ToList();
        }

        public override void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGV.Rows[e.RowIndex];
                DisableForm();

                selectedTranslationId = row.Cells["TranslationID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["TranslationID"].Value) : (int?)null;
                ddElementKey.SelectedValue = elementKeyController.GetElementKeyIdByKey(row.Cells["Key"].Value.ToString());
                ddLanguage.SelectedValue = languageController.GetLanguageIdByName(row.Cells["LanguageName"].Value.ToString());
                txtTranslationText.Text = row.Cells["TranslationText"].Value?.ToString();
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // Validate text fields
            errTranslationText.Visible = string.IsNullOrWhiteSpace(txtTranslationText.Text);
            errLanguage.Visible = ddLanguage.SelectedIndex == -1;
            errElementKey.Visible = ddElementKey.SelectedIndex == -1;

            // Show error message if any validation failed
            if (errTranslationText.Visible || errLanguage.Visible || errElementKey.Visible)
            {
                Utility.ShowMsg("Fields with * are mandatory!", "Error", "Error");
                isValid = false;
            }

            return isValid;
        }

    }
}
