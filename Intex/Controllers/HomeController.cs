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
using Intex.Infrastructure;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        private iCrashesRepository repo { get; set; }
        private iCountyRepository countyRepo { get; set; }


        public HomeController(iCrashesRepository temp, iCountyRepository temp2)
        {
            repo = temp;
            countyRepo = temp2;
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

        
        public async Task<IActionResult> Summary(
            string sortOrder,
            string searchString,
            string currentFilter,
            int countySearchID,
            int? pageNumber)
        {
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CountyIDSortParm"] = sortOrder == "County" ? "county_desc" : "County";
            ViewData["RouteSortParm"] = sortOrder == "Route" ? "route_desc" : "Route";
            ViewData["MPSortParm"] = sortOrder == "MP" ? "MP_desc" : "MP";
            ViewData["LatSortParm"] = sortOrder == "Lat" ? "lat_desc" : "Lat";
            ViewData["LonSortParm"] = sortOrder == "Lon" ? "lon_desc" : "Lon";
            ViewData["RoadSortParm"] = sortOrder == "Road" ? "road_desc" : "Road";
            ViewData["SLSortParm"] = sortOrder == "SL" ? "lat_desc" : "SL";

            ViewData["CurrentSort"] = sortOrder;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            ViewData["CountytFilter"] = countySearchID;

            ViewBag.Counties = countyRepo.Counties.ToList();
            var crashes = from s in repo.Crashes select s;

            if (searchString != null)
            {
                if(countySearchID > 0)
                {
                    crashes = crashes.Where(s => s.MAIN_ROAD_NAME.Contains(searchString)
                    && s.COUNTY_ID == countySearchID);
                }
                else
                {
                    crashes = crashes.Where(s => s.MAIN_ROAD_NAME.Contains(searchString));
                }

            }
            else if ((searchString is null) && countySearchID > 0)
            {
                crashes = crashes.Where(s => s.COUNTY_ID == countySearchID);
            }
           
            switch (sortOrder)
            {
                
                case "date_desc":
                    crashes = crashes.OrderByDescending(s => s.CRASH_DATETIME);
                    break;
                case "County":
                    crashes = crashes.OrderBy(s => s.COUNTY_ID);
                    break;
                case "county_desc":
                    crashes = crashes.OrderByDescending(s => s.COUNTY_ID);
                    break;
                case "Route":
                    crashes = crashes.OrderBy(s => s.ROUTE);
                    break;
                case "route_desc":
                    crashes = crashes.OrderByDescending(s => s.ROUTE);
                    break;
                case "MP":
                    crashes = crashes.OrderBy(s => s.MILEPOINT);
                    break;
                case "MP_desc":
                    crashes = crashes.OrderByDescending(s => s.MILEPOINT);
                    break;
                case "Lat":
                    crashes = crashes.OrderBy(s => s.LAT_UTM_Y);
                    break;
                case "lat_desc":
                    crashes = crashes.OrderByDescending(s => s.LAT_UTM_Y);
                    break;
                case "Lon":
                    crashes = crashes.OrderBy(s => s.LONG_UTM_X);
                    break;
                case "lon_desc":
                    crashes = crashes.OrderByDescending(s => s.LONG_UTM_X);
                    break;
                case "SL":
                    crashes = crashes.OrderBy(s => s.CRASH_SEVERITY_ID);
                    break;
                case "SL_desc":
                    crashes = crashes.OrderByDescending(s => s.CRASH_SEVERITY_ID);
                    break;
                case "road_desc":
                    crashes = crashes.OrderByDescending(s => s.MAIN_ROAD_NAME);
                    break;
                case "Road":
                    crashes = crashes.OrderBy(s => s.MAIN_ROAD_NAME);
                    break;

                default:
                    crashes = crashes.OrderBy(s => s.CRASH_DATETIME);
                    break;
            }
            int pageSize = 10;
            
            return View(await PaginatedList<Crash>.CreateAsync(crashes.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public IActionResult Privacy()
        {
            return View();
        }



    }
}

