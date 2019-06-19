using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using unirest;

namespace Infrastructure
{
    class RecipeClient : IRecipeClient
    {
        public JObject GetRecipeById(string id)
        {
            string url = "https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes" + id + "information";
            var response = Unirest.get(url)
               .header("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com")
               .header("X-RapidAPI-Key", "82e89ff980msh7da50a51185a3a1p10ddf2jsnc8633e45f495")
               .asJson<JObject>().Body;
            return response;
        }

        //public JObject SearchRecipe()
    }
}
