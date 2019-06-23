using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace ChefPrive.Models
{
    public class MealPlanViewModel
    {
        public List<Recipe> Recipes { get; set; }
        
        public MealPlanViewModel(List<Recipe> recipes)
        {
            Recipes = recipes;
        }
    }
}
