using EmployeeSupervisionApp.Data;
using EmployeeSupervisionApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSupervisionApp.Controllers
{
    public class TranslationController
    {
        private readonly CompanyContext context;

        public TranslationController()
        {
            context = new CompanyContext();
        }

        public List<Translation> GetAllTranslations()
        {
            return context.Translations.Include(t => t.ElementKey).Include(t => t.Language).ToList();
        }

        public List<Translation> SearchTranslations(string searchText)
        {
            return context.Translations
                .Include(t => t.ElementKey)
                .Include(t => t.Language)
                .Where(t => t.ElementKey.Key.Contains(searchText) ||
                            t.Language.LanguageName.Contains(searchText) ||
                            t.TranslationText.Contains(searchText))
                .ToList();
        }

        public void AddOrUpdateTranslation(Translation translation)
        {
            var existingTranslation = context.Translations
                .FirstOrDefault(t => t.ElementKeyID == translation.ElementKeyID && t.LanguageID == translation.LanguageID);

            if (existingTranslation != null)
            {
                existingTranslation.TranslationText = translation.TranslationText;
                context.Translations.Update(existingTranslation);
            }
            else
            {
                context.Translations.Add(translation);
            }

            context.SaveChanges();
        }

        public void DeleteTranslation(int translationId)
        {
            var translation = context.Translations.Find(translationId);
            if (translation != null)
            {
                context.Translations.Remove(translation);
                context.SaveChanges();
            }
        }
    }
}
