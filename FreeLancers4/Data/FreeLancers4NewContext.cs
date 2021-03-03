using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FreeLancers4.Models;

namespace FreeLancers4.Data
{
    public class FreeLancers4NewContext : DbContext
    {
        public FreeLancers4NewContext (DbContextOptions<FreeLancers4NewContext> options)
            : base(options)
        {
        }

        public DbSet<FreeLancers4.Models.MyHistory> MyHistory { get; set; }

        public DbSet<FreeLancers4.Models.Work> Work { get; set; }
    }
}
