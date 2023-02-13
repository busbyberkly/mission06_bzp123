using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission06_bzp123.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_bzp123.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieEntryContex MovieContext { get; set; }

        //constructor
        public HomeController(ILogger<HomeController> logger, MovieEntryContex movieEntry)
        {
            _logger = logger;
            MovieContext = movieEntry;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(NewMovieForm nmf)
        {
            if (ModelState.IsValid)
            {
                MovieContext.Add(nmf);
                MovieContext.SaveChanges();
                return View("Confirmation", nmf);
            }
            else 
            { 
                return View(); 
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
