using EmployeeSupervisionApp.Data;
using EmployeeSupervisionApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSupervisionApp.Controllers
{
    public class ElementKeyController
    {
        private readonly CompanyContext context;

        public ElementKeyController()
        {
            context = new CompanyContext();
        }

        public List<ElementKey> GetAllElementKeys()
        {
            return context.ElementKeys.ToList();
        }

        public int GetElementKeyIdByKey(string key)
        {
            var elementKey = context.ElementKeys.FirstOrDefault(ek => ek.Key == key);
            return elementKey?.ElementKeyID ?? 0;
        }

        public void AddElementKey(ElementKey elementKey)
        {
            context.ElementKeys.Add(elementKey);
            context.SaveChanges();
        }

        public void UpdateElementKey(ElementKey elementKey)
        {
            var existingElementKey = context.ElementKeys.Find(elementKey.ElementKeyID);
            if (existingElementKey != null)
            {
                existingElementKey.Key = elementKey.Key;
                context.SaveChanges();
            }
        }

        public void DeleteElementKey(int elementKeyId)
        {
            var elementKey = context.ElementKeys.Find(elementKeyId);
            if (elementKey != null)
            {
                context.ElementKeys.Remove(elementKey);
                context.SaveChanges();
            }
        }
    }
}
