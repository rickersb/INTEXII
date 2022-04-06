using System;
using System.Linq;

namespace Intex.Models
{
    public class EFCountyRepository : ICountyRepository
    {
        private CountyDbContext _context { get; set; }

        public EFCountyRepository(CountyDbContext temp)
        {
            _context = temp;
        }



        public IQueryable<County> Counties => _context.Counties;


        public void SaveCounty(County c)
        {
            _context.SaveChanges();
        }

        public void CreateCounty(County c)
        {
            _context.Add(c);
            _context.SaveChanges();
        }

        public void DeleteCounty(County c)
        {
            _context.Remove(c);
            _context.SaveChanges();
        }
    }
}