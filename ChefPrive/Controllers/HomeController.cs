using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using unirest;
using Newtonsoft.Json.Linq;
using Infrastructure;
using Newtonsoft.Json;
using Application;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace ChefPrive.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string searchString) {
                var recipes = from r in _context.Recipes
                             select r;
                if (!String.IsNullOrEmpty(searchString))
                {
                recipes = recipes.Where(s => s.Title.Contains(searchString));
                }
                return View(await recipes.ToListAsync());
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
