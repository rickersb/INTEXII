using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Intex.Models.ViewModels;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        private iCrashesRepository repo { get; set; }


     
        public HomeController(iCrashesRepository temp)
        {
            repo = temp;
        }

   
        public IActionResult Index()
        {
            /*var x = repo.Crashes
                .ToList();*/

            return View();
        }

        public IActionResult Graphs()
        {
            return View();
        }
        public IActionResult Predictor()
        {
            return View();
        }
        public IActionResult Summary(int pageNum = 1)
        {
            int pageSize = 15;

            var x = new RecordsViewModel
            {
                Crashes = repo.Crashes
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumRecords = repo.Crashes.Count(),
                    RecordsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            

           
            

            return View(x);
        }

        public IActionResult Privacy()
        {
            return View();
        }



    }
}

