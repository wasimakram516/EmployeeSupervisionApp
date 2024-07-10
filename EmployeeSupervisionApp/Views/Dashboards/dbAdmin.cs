using EmployeeSupervisionApp.Controllers.Global;
using EmployeeSupervisionApp.Views.Common;
using System;
using System.Linq;
using System.Windows.Forms;
using EmployeeSupervisionApp.Controllers;
using EmployeeSupervisionApp.Services;

namespace EmployeeSupervisionApp.Views.Dashboards
{
    public partial class dbAdmin : BaseWindow, ITranslatable
    {
        private LanguageController languageController;
        private bool initializingLanguageDropdown = false;

        public dbAdmin()
        {
            InitializeComponent();
            languageController = new LanguageController();
            LoadLanguages();
            GlobalSettings.LanguageChanged += ApplyTranslations; // Subscribe to the event
            ApplyTranslations();
        }

        private void LoadLanguages()
        {
            initializingLanguageDropdown = true;

            var languages = languageController.GetAllLanguages()
                .Select(lang => new { DisplayName = $"{lang.LanguageName} ({lang.LanguageCode})", lang.LanguageCode })
                .ToList();

            ddLanguage.DataSource = languages;
            ddLanguage.DisplayMember = "DisplayName";
            ddLanguage.ValueMember = "LanguageCode";

            // Set the selected language from global settings
            if (!string.IsNullOrEmpty(GlobalSettings.LanguageCode))
            {
                ddLanguage.SelectedValue = GlobalSettings.LanguageCode;
            }
            else if (ddLanguage.Items.Count > 0)
            {
                ddLanguage.SelectedIndex = 0; // Select the first language by default
            }

            ddLanguage.SelectedIndexChanged += ddLanguage_SelectedIndexChanged;

            initializingLanguageDropdown = false;
        }

        private void ddLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initializingLanguageDropdown && ddLanguage.SelectedValue != null)
            {
                var selectedLanguageCode = ddLanguage.SelectedValue.ToString();
                GlobalSettings.LanguageCode = selectedLanguageCode;
            }
        }

        public void ApplyTranslations()
        {
            var translationService = new TranslationService(GlobalSettings.LanguageCode);

            lblUserDetails.Text = translationService.Translate("label_user_details");
            btnLanguages.Text = translationService.Translate("button_languages");
            btnTranslations.Text = translationService.Translate("button_translations");
            btnEmployees.Text = translationService.Translate("button_employees");
            // Apply translations for other controls as needed
        }

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            Languages obj = new Languages();
            Utility.ShowWindow(obj, this);
        }

        private void btnTranslations_Click(object sender, EventArgs e)
        {
            Translations obj = new Translations();
            Utility.ShowWindow(obj, this);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            Utility.ShowWindow(obj, this);
        }
    }
}
