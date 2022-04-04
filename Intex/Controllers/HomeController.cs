using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex.Models;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        private CrashesDbContext _context { get; set; }


        public HomeController(CrashesDbContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            var blah = _context.Crashes.Single(x => x.CRASH_ID == 10805517);
            return View(blah);
        }
        public IActionResult Graphs()
        {
            return View();
        }
        public IActionResult Predictor()
        {
            return View();
        }
        public IActionResult Summary()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
