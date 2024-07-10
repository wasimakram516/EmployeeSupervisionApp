using Microsoft.EntityFrameworkCore;
using EmployeeSupervisionApp.Models;
using System;
using System.Linq;
using EmployeeSupervisionApp.Controllers.Global;

namespace EmployeeSupervisionApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CompanyContext context)
        {
            context.Database.EnsureCreated();

            // Languages
            if (!context.Languages.Any()) 
            {
                var lang = new Language
                {
                    LanguageCode = "en",
                    LanguageName = "English",
                };
                context.Languages.Add(lang);
                context.SaveChanges();
            }

            // Seed Employees
            if (!context.Employees.Any())
            {
                var adminUser = new Employee
                {
                    Name = "Admin User",
                    Position = "Administrator",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    DateOfJoining = DateTime.Now,
                    Email = "admin@admin.com",
                    PhoneNumber = "1234567890",
                    Address = "Admin Address",
                    Department = "Admin Department",
                    Gender = Gender.Male,
                    Password = Utility.HashPassword("@admin123"),
                    UserType = UserType.Admin,
                    IsActive = true,
                };

                context.Employees.Add(adminUser);
                context.SaveChanges();
            }

            // Seed ElementKeys
            if (!context.ElementKeys.Any())
            {
                var elementKeys = new[]
                {
                    new ElementKey { Key = "label_name" },
                    new ElementKey { Key = "label_position" },
                    new ElementKey { Key = "label_date_of_birth" },
                    new ElementKey { Key = "label_date_of_joining" },
                    new ElementKey { Key = "label_date_of_left" },
                    new ElementKey { Key = "label_email" },
                    new ElementKey { Key = "label_phone_number" },
                    new ElementKey { Key = "label_address" },
                    new ElementKey { Key = "label_department" },
                    new ElementKey { Key = "label_gender" },
                    new ElementKey { Key = "label_user_type" },
                    new ElementKey { Key = "label_is_active" },
                    new ElementKey { Key = "label_password" },
                    new ElementKey { Key = "button_add" },
                    new ElementKey { Key = "button_edit" },
                    new ElementKey { Key = "button_save" },
                    new ElementKey { Key = "button_delete" },
                    new ElementKey { Key = "button_view" }
                };

                context.ElementKeys.AddRange(elementKeys);
                context.SaveChanges();
            }
        }
    }
}
