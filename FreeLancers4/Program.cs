using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FreeLancers4.Models;
using FreeLancers4.Data;

namespace FreeLancers4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            //adding seed data
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<FreeLancers4Context>();
                    context.Database.Migrate();
                    //calling the creation function
                    SeedData.Initialize(services);
                }
                catch(Exception ex)
                {
                    var logs = services.GetRequiredService<ILogger<Program>>();
                    logs.LogError(ex, "An error has occured during the seeding of the database");
                }

            }
                host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
