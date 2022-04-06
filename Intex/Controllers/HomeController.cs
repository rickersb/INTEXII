﻿using System;
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
        private iCrashesRepository repo { get; set; }


     
        public HomeController(iCrashesRepository temp)
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
           

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



    }
}

