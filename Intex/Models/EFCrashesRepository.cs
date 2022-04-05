using System;
using System.Linq;

namespace Intex.Models
{
    public class EFCrashesRepository : iCrashesRepository
    {
        private CrashesDbContext _context { get; set; }

        public EFCrashesRepository(CrashesDbContext temp)
        {
            _context = temp;
        }



        public IQueryable<Crash> Crashes => _context.Crashes;

        public void SaveCrash(Crash c)
        {
            _context.SaveChanges();
        }

        public void CreateCrash(Crash c)
        {
            _context.Add(c);
            _context.SaveChanges();
        }

        public void DeleteCrash(Crash c)
        {
            _context.Remove(c);
            _context.SaveChanges();
        }
    }
}


