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
        private ICrashesRepository repo { get; set; }
        private ICountyRepository countyRepo { get; set; }
        private ICityRepository cityRepo { get; set; }

        public HomeController(ICrashesRepository temp, ICountyRepository temp2, ICityRepository temp3)
        {
            repo = temp;
            countyRepo = temp2;
            cityRepo = temp3;
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
        public async Task<IActionResult> Summary(
            string sortOrder,
            string searchString,
            string currentFilter,
            int countyFilter,
            int countySearchID,
            int cityFilter,
            int citySearchID,
            int? pageNumber)
        {
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CountyIDSortParm"] = sortOrder == "County" ? "county_desc" : "County";
            ViewData["CityIDSortParm"] = sortOrder == "City" ? "city_desc" : "City";
            ViewData["RouteSortParm"] = sortOrder == "Route" ? "route_desc" : "Route";
            ViewData["MPSortParm"] = sortOrder == "MP" ? "MP_desc" : "MP";
            ViewData["LatSortParm"] = sortOrder == "Lat" ? "lat_desc" : "Lat";
            ViewData["LonSortParm"] = sortOrder == "Lon" ? "lon_desc" : "Lon";
            ViewData["RoadSortParm"] = sortOrder == "Road" ? "road_desc" : "Road";
            ViewData["SLSortParm"] = sortOrder == "SL" ? "SL_desc" : "SL";

            ViewData["CurrentSort"] = sortOrder;
            if ((searchString != null) || (countySearchID > 0) || (citySearchID > 0))
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
                countySearchID = countyFilter;
                citySearchID = cityFilter;

            }

            ViewData["CurrentFilter"] = searchString;
            ViewData["CountyFilter"] = countySearchID;
            ViewData["CityFilter"] = citySearchID;

            ViewBag.Counties = countyRepo.Counties.ToList();
            ViewBag.Cities = cityRepo.Cities.ToList();

            var crashes = from s in repo.Crashes select s;

            if (searchString != null)
            {
                if ((citySearchID > 0) && (countySearchID > 0))
                {
                    crashes = crashes.Where(s => s.MAIN_ROAD_NAME.Contains(searchString)
                    && ((s.CITY_ID == citySearchID) && (s.COUNTY_ID == countySearchID)));
                }
                else if ((citySearchID > 0) || (countySearchID > 0))
                {
                    crashes = crashes.Where(s => s.MAIN_ROAD_NAME.Contains(searchString)
                    && ((s.CITY_ID == citySearchID) || (s.COUNTY_ID == countySearchID)));
                }
                else
                {
                    crashes = crashes.Where(s => s.MAIN_ROAD_NAME.Contains(searchString));
                }

            }
            else if ((searchString is null) && ((citySearchID > 0) || countySearchID > 0))
            {
                if (citySearchID > 0)
                {
                    crashes = crashes.Where(s => s.CITY_ID == citySearchID);
                }
                if (countySearchID > 0)
                {
                    crashes = crashes.Where(s => s.COUNTY_ID == countySearchID);
                }
                if ((countySearchID > 0) && (citySearchID > 0))
                {
                    crashes = crashes.Where(s => (s.CITY_ID == citySearchID) && (s.COUNTY_ID == countySearchID));
                }


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
                case "City":
                    crashes = crashes.OrderBy(s => s.CITY_ID);
                    break;
                case "city_desc":
                    crashes = crashes.OrderByDescending(s => s.CITY_ID);
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

        public IActionResult Details(int id)
        {
            ViewBag.County = countyRepo.Counties.ToList();
            ViewBag.City = cityRepo.Cities.ToList();
            var Details = repo.Crashes
                .Single(x => x.CRASH_ID == id);

            return View("Details", Details);
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

