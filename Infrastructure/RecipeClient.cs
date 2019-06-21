using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using unirest;

namespace Infrastructure
{
    public class RecipeClient : IRecipeClient
    {
        public JObject GetRecipeById(string id)
        {        
            string url = "https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/" + id + "/information";
            var response = Unirest.get(url)
               .header("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com")
               .header("X-RapidAPI-Key", "82e89ff980msh7da50a51185a3a1p10ddf2jsnc8633e45f495")
               .asJson<JObject>().Body;
            Console.WriteLine(response);
            return response;
        }

        public JArray SearchRecipeByIngredients(int numberOfRecipesReturned, string ingredients)
        {
            var response = Unirest.get("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/findByIngredients?" +
                "number=" + numberOfRecipesReturned + "&ranking=1&ignorePantry=false&" +
                "ingredients=" + System.Web.HttpUtility.UrlEncode(ingredients))
                .header("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com")
                .header("X-RapidAPI-Key", "82e89ff980msh7da50a51185a3a1p10ddf2jsnc8633e45f495")
                .asJson<JArray>().Body;
            return response;
        }

         public JObject SearchRecipe(string diet, string excludeIngredients, string intolerances, int numberOfRecipes, string type, string query)
        {

            var response = Unirest.get("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/search?" + 
                "diet=" + diet + 
                "&excludeIngredients=" + System.Web.HttpUtility.UrlEncode(excludeIngredients) +  
                "&intolerances=" + System.Web.HttpUtility.UrlEncode(intolerances) + 
                "&number=" + numberOfRecipes + 
                "&offset=0&type=" + System.Web.HttpUtility.UrlEncode(type) + 
                "&query=" + System.Web.HttpUtility.UrlEncode(query))
                .header("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com")
                .header("X-RapidAPI-Key", "82e89ff980msh7da50a51185a3a1p10ddf2jsnc8633e45f495")
                .asJson<JObject>().Body;
            return response;
        }

        public JArray RecommendRecipes(string id)
        {
            var response = Unirest.get("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/" + id + "/similar")
                .header("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com")
                .header("X-RapidAPI-Key", "82e89ff980msh7da50a51185a3a1p10ddf2jsnc8633e45f495")
                .asJson<JArray>().Body;
            return response;
        }

        public JObject GetMealPlan(string timeFrame, int targetCalories, string diet, string exclude)
        {
            var response = Unirest.get("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/mealplans/generate?" + 
                "timeFrame=" + timeFrame + 
                "&targetCalories=" + targetCalories + 
                "&diet=" + diet +
                "&exclude=" + System.Web.HttpUtility.UrlEncode(exclude))
                .header("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com")
                .header("X-RapidAPI-Key", "82e89ff980msh7da50a51185a3a1p10ddf2jsnc8633e45f495")
                .asJson<JObject>().Body;
            return response;
        }
    }
}
