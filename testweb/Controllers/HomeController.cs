using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testweb.Models;

namespace testweb.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(StoreContext dbContext)
        {
            DbContext = dbContext;
        }

        public StoreContext DbContext { get; }

        public async Task<IActionResult> Index()
        {
            var genres = await DbContext.categories.ToListAsync();

            return View(genres);
        }

       
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { Requestid = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
