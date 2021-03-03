using System;
using FreeLancers4.Areas.Identity.Data;
using FreeLancers4.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FreeLancers4.Areas.Identity.IdentityHostingStartup))]
namespace FreeLancers4.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FreeLancers4Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FreeLancers4ContextConnection")));

                services.AddDefaultIdentity<FreeLancers4User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FreeLancers4Context>();
            });
        }
    }
}