using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        
        private MovieEntryContex MovieContext { get; set; }

        //constructor
        public HomeController(MovieEntryContex movieEntry)
        {
            
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
            ViewBag.Categories =  MovieContext.Categories.ToList();
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
                ViewBag.Categories = MovieContext.Categories.ToList();
                return View(); 
            }
        }
        public IActionResult MovieList()
        {
            var entries = MovieContext.NewMovies
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(entries);
        }

        [HttpGet]
        public IActionResult Edit(int formid)
        {
            ViewBag.Categories = MovieContext.Categories.ToList();
            var entry = MovieContext.NewMovies.Single(x => x.FormID == formid);
            return View("Form", entry);
        }
        
        [HttpPost]
        public IActionResult Edit(NewMovieForm editedentry)
        {
            
                MovieContext.Update(editedentry);
                MovieContext.SaveChanges();
                return RedirectToAction("MovieList");          
            
            
            
        }

        [HttpGet]
        public IActionResult Delete(int formid)
        {
            
            var entry = MovieContext.NewMovies.Single(x => x.FormID == formid);
            return View(entry);
            
        }
        [HttpPost]
        public IActionResult Delete(NewMovieForm removemovie)
        {
            MovieContext.NewMovies.Remove(removemovie);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
