using EmployeeSupervisionApp.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace EmployeeSupervisionApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<CompanyContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    // Log any errors in seeding the database.
                    Console.WriteLine(ex.Message);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent());
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<CompanyContext>();
                    services.AddScoped<CompanyContext>();
                });
    }
}
