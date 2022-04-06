using System;
using System.Linq;

namespace Intex.Models
{
    public interface ICountyRepository
    {
        IQueryable<County> Counties { get; }


        public void SaveCounty(County c);
        public void CreateCounty(County c);
        public void DeleteCounty(County c);
    }
}
