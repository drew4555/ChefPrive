using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using unirest;
using Newtonsoft.Json.Linq;

namespace ChefPrive.Controllers
{
    public class HomeController : Controller
    {
        //HttpResponse<string> jsonResponse = Unirest.get("")
        //    .header("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com")
        //    .header("X-RapidAPI-Key", "82e89ff980msh7da50a51185a3a1p10ddf2jsnc8633e45f495")
        //    .asJsonAsync<string>();
        //var myBody = jsonResponse.Body;



        public IActionResult Index()
        {
<<<<<<< HEAD
            return View();

            
=======
           return View();            
>>>>>>> ccf289d320ba5a83e7fd4b4c8188e978432177bb
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
