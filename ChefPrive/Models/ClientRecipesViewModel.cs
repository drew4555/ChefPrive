using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace ChefPrive.Models
{
    public class ClientRecipesViewModel
    {
        public List<Recipe> Recipes { get; set; }
        
        public ClientRecipesViewModel(List<Recipe> recipes)
        {
            Recipes = recipes;
        }
    }
}
