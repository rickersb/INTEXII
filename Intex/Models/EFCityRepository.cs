using System;
using System.Linq;

namespace Intex.Models
{
    public class EFCityRepository : ICityRepository
    {
        private CityDbContext _context { get; set; }

        public EFCityRepository(CityDbContext temp)
        {
            _context = temp;
        }



        public IQueryable<City> Cities => _context.Cities;


        public void SaveCity(City c)
        {
            _context.SaveChanges();
        }

        public void CreateCity(City c)
        {
            _context.Add(c);
            _context.SaveChanges();
        }

        public void DeleteCity(City c)
        {
            _context.Remove(c);
            _context.SaveChanges();
        }
    }
}