using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    public class CityDbContext : DbContext
    {
        public CityDbContext(DbContextOptions<CityDbContext> options) : base(options)
        {

        }

     
        public DbSet<City> Cities { get; set; }
    }
}
