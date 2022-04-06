using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex.Models;
using Microsoft.EntityFrameworkCore;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        private ICrashesRepository repo { get; set; }
     
        public HomeController(ICrashesRepository temp)
        {
            repo = temp;
        }

   
        public IActionResult Index()
        {
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
        public IActionResult Summary()
        {
        
            var x = repo.Crashes.ToList();

            return View(x);
        }
        public IActionResult Admin()
        {

            var x = repo.Crashes.ToList();

            return View(x);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //form for creating and editing
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Crash c)
        {
            if (ModelState.IsValid)
            {
                if (c.CRASH_ID > 0)
                {
                    repo.SaveCrash(c);
                    return RedirectToAction("Index");
                }
                else
                {
                    repo.CreateCrash(c);
                    return RedirectToAction("Confirmation");
                }

            }
            else
            {

                return View();
            }
        }

        public IActionResult Edit(int crashid)
        {
            var crash = repo.Crashes
                 .Single(x => x.CRASH_ID == crashid);


            return View("Create", crash);
        }


        //delete a record
        public IActionResult Delete(int crashid)
        {
            var crash = repo.Crashes
                 .Single(x => x.CRASH_ID == crashid);
            repo.DeleteCrash(crash);

            return RedirectToAction("Index");
        }
        public IActionResult Confirmation() => View();



    }
}

