using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
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
            //_context.Recipes.Add(recipe);
            //_context.SaveChangesAsync();
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
