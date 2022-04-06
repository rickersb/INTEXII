using System;
using System.Linq;

namespace Intex.Models
{
    public interface ICrashesRepository
    {
        IQueryable<Crash> Crashes { get; }

        public void SaveCrash(Crash c);
        public void CreateCrash(Crash c);
        public void DeleteCrash(Crash c);
    }
}

