using Microsoft.EntityFrameworkCore;
using EmployeeSupervisionApp.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace EmployeeSupervisionApp.Data
{
    public class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<ElementKey> ElementKeys { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<CheckInCheckOut> CheckInCheckOuts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=employee_supervision;user=root;password=@Saim0983",
                new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}
