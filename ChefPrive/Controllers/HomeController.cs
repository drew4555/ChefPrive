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

namespace ChefPrive.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() { 

        //{
        //    ClientRecipeInfo myInfo = new ClientRecipeInfo();
        //    var recipe = myInfo.GetRecipeById("479101");
        //    Recipe newRecipe = new Recipe();
        //    newRecipe.Title = recipe.Title;
        //    newRecipe.IsVegan = recipe.IsVegan;
        //    newRecipe.Image = recipe.Image;
        //    newRecipe.IsVegetarian = recipe.IsVegetarian;
        //    newRecipe.Instructions = recipe.Instructions;
        //    newRecipe.MarkedAsFavorite = recipe.MarkedAsFavorite;
        //    newRecipe.Url = recipe.Url;
        //    newRecipe.Comment = recipe.Comment;
        //    newRecipe.Servings = recipe.Servings;
        //    //newRecipe = recipe;
        //    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var client = _context.Clients.Where(c => c.ApplicationUserId == userId).FirstOrDefault();
        //    newRecipe.ClientId = client.Id;
        //    _context.Recipes.Add(newRecipe);
        //    await _context.SaveChangesAsync();
        //    //return RedirectToAction("Index", "Recipes");
            return View();
    
            


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
