using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using System.Text;
using unirest;

namespace Application
{
    public class ClientRecipeInfo : IRecipeClient
    {
        
        public ApplicationDbContext _context;

        public ClientRecipeInfo()
        {
            
        }

        public Recipe GetRecipeById(string id)
        {
            RecipeClient recipeClient = new RecipeClient();
            var recipe = recipeClient.GetRecipeById(id);
            Recipe newRecipe = new Recipe();
            newRecipe.Title = recipe.Title;
            newRecipe.IsVegan = recipe.IsVegan;
            newRecipe.Image = recipe.Image;
            newRecipe.IsVegetarian = recipe.IsVegetarian;
            newRecipe.Instructions = recipe.Instructions;
            newRecipe.MarkedAsFavorite = recipe.MarkedAsFavorite;
            newRecipe.Url = recipe.Url;
            newRecipe.Comment = recipe.Comment;
            newRecipe.Servings = recipe.Servings;
            //newRecipe = recipe;
            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var client = _context.Clients.Where(c => c.ApplicationUserId == userId).FirstOrDefault();
            //newRecipe.ClientId = client.Id;
            _context.Recipes.Add(newRecipe);
             _context.SaveChangesAsync();
            //    //return RedirectToAction("Index", "Recipes");
            return recipe;
        }
        public Recipe[] SearchRecipeByIngredients(int numberOfRecipesReturned, string ingredients)
        {
            
            RecipeClient recipeClient = new RecipeClient();
            var recipes = recipeClient.SearchRecipeByIngredients(numberOfRecipesReturned, ingredients);
            return recipes;           
        }
        public Recipe SearchRecipe(string diet, string excludeIngredients, string intolerances, int numberOfRecipes, string type, string query)
        {
            RecipeClient recipeClient = new RecipeClient();
            var recipe = recipeClient.SearchRecipe(diet, excludeIngredients, intolerances, numberOfRecipes, type, query);
            return recipe;
        }
        public Recipe[] RecommendRecipes(string id)
        {
            RecipeClient recipeClient = new RecipeClient();
            var recipes = recipeClient.RecommendRecipes(id);
            return recipes;
        }
        public Recipe GetMealPlan(string timeFrame, int targetCalories, string diet, string exclude)
        {
            RecipeClient recipeClient = new RecipeClient();
            var recipe = recipeClient.GetMealPlan(timeFrame, targetCalories, diet, exclude);
            return recipe;

        }

    }
}
