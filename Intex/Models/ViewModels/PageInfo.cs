﻿using System;
namespace Intex.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumRecords { get; set; }
        public int RecordsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int) Math.Ceiling((double) TotalNumRecords / RecordsPerPage);


    }
}
