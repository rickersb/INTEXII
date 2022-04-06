using System;
using System.Linq;

namespace Intex.Models
{
    public interface ICityRepository
    {
        IQueryable<City> Cities { get; }


        public void SaveCity(City c);
        public void CreateCity(City c);
        public void DeleteCity(City c);
    }
}
