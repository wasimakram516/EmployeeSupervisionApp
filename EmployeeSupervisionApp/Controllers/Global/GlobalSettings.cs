namespace EmployeeSupervisionApp.Controllers.Global
{
    public static class GlobalSettings
    {
        private static string _languageCode = "en"; // Default to English
        public static event Action LanguageChanged;

        public static string LanguageCode
        {
            get => _languageCode;
            set
            {
                if (!string.IsNullOrEmpty(value) && _languageCode != value)
                {
                    _languageCode = value;
                    LanguageChanged?.Invoke();
                }
            }
        }
    }
}
