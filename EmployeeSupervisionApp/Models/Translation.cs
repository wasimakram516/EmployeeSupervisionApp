using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSupervisionApp.Models
{
    public class Translation
    {
        public int TranslationID { get; set; }
        public int ElementKeyID { get; set; }
        public int LanguageID { get; set; }
        public string TranslationText { get; set; }

        public virtual ElementKey ElementKey { get; set; }
        public virtual Language Language { get; set; }
    }

}
