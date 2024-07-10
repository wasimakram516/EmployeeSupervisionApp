using EmployeeSupervisionApp.Data;
using EmployeeSupervisionApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSupervisionApp.Controllers
{
    public class LanguageController
    {
        private readonly CompanyContext context;

        public LanguageController()
        {
            context = new CompanyContext();
        }

        public List<Language> GetAllLanguages()
        {
            return context.Languages.ToList();
        }

        public List<Language> SearchLanguages(string searchText)
        {
            return context.Languages
                .Where(l => l.LanguageName.Contains(searchText) || l.LanguageCode.Contains(searchText))
                .ToList();
        }

        public void AddLanguage(Language language)
        {
            context.Languages.Add(language);
            context.SaveChanges();
        }

        public void UpdateLanguage(Language language)
        {
            var existingLanguage = context.Languages.Find(language.LanguageID);
            if (existingLanguage != null)
            {
                existingLanguage.LanguageName = language.LanguageName;
                existingLanguage.LanguageCode = language.LanguageCode;
                context.SaveChanges();
            }
        }

        public void DeleteLanguage(int languageId)
        {
            var language = context.Languages.Find(languageId);
            if (language != null)
            {
                context.Languages.Remove(language);
                context.SaveChanges();
            }
        }

        public int? GetLanguageIdByName(string languageName)
        {
            var language = context.Languages.FirstOrDefault(l => l.LanguageName == languageName);
            return language?.LanguageID;
        }
    }
}
