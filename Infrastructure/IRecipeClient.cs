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
        Recipe[] SearchRecipeByIngredients(int numberOfRecipesReturned, string ingredients);
        Recipe SearchRecipe(string diet, string excludeIngredients, string intolerances, int numberOfRecipes, string type, string query);
        Recipe[] RecommendRecipes(string id);
        Recipe GetMealPlan(string timeFrame, int targetCalories, string diet, string exclude);

    }
}
