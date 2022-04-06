using System;
using System.Linq;

namespace Intex.Models
{
    public interface iCountyRepository
    {
        IQueryable<County> Counties { get; }


        public void SaveCounty(County c);
        public void CreateCounty(County c);
        public void DeleteCounty(County c);
    }
}
