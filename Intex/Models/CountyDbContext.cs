using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    public class CountyDbContext : DbContext
    {
        public CountyDbContext(DbContextOptions<CountyDbContext> options) : base(options)
        {

        }

     
        public DbSet<County> Counties { get; set; }
    }
}
