using EmployeeSupervisionApp.Controllers.Global;
using EmployeeSupervisionApp.Data;
using EmployeeSupervisionApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeSupervisionApp.Services
{
    public class TranslationService
    {
        private readonly CompanyContext context;
        private string currentLanguageCode;

        public TranslationService(string languageCode = "en")
        {
            context = new CompanyContext();
            currentLanguageCode = languageCode;
        }

        public string Translate(string key)
        {
            EnsureKeyExists(key);

            var language = context.Languages.FirstOrDefault(l => l.LanguageCode == currentLanguageCode);
            if (language != null)
            {
                var translation = context.Translations
                    .Include(t => t.ElementKey)
                    .FirstOrDefault(t => t.ElementKey.Key == key && t.LanguageID == language.LanguageID);
                if (translation != null)
                {
                    return translation.TranslationText;
                }
            }
            return key; // Return key if translation not found
        }

        private void EnsureKeyExists(string key)
        {
            if (!context.ElementKeys.Any(e => e.Key == key))
            {
                var elementKey = new ElementKey { Key = key };
                context.ElementKeys.Add(elementKey);
                context.SaveChanges();
            }
        }

        public void SetLanguage(string languageCode)
        {
            currentLanguageCode = languageCode;
        }
    }
}
