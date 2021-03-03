using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeLancers4.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreeLancers4.Data
{
    public class FreeLancers4Context : IdentityDbContext<FreeLancers4User>
    {
        public FreeLancers4Context(DbContextOptions<FreeLancers4Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<FreeLancers4.Models.Work> Work { get; set; }

        public DbSet<FreeLancers4.Models.History> History { get; set; }

    }
}
