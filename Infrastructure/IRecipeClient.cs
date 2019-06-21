using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Infrastructure
{
    public interface IRecipeClient
    {

        Recipe GetRecipeById(string id);
        JArray SearchRecipeByIngredients(int numberOfRecipesReturned, string ingredients);
        JObject SearchRecipe(string diet, string excludeIngredients, string intolerances, int numberOfRecipes, string type, string query);
        JArray RecommendRecipes(string id);
        JObject GetMealPlan(string timeFrame, int targetCalories, string diet, string exclude);

    }
}
