using System;
using System.Linq;

namespace Intex.Models.ViewModels
{
    public class RecordsViewModel
    {
            public IQueryable<Crash> Crashes { get; set; }
            public PageInfo PagInfo { get; set; }
            public PageInfo PageInfo { get; internal set; }
        
    }
}
