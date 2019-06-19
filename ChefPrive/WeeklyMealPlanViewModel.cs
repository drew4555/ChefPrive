using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace ChefPrive.Models
{
    public class WeeklyMealPlanViewModel
    {
      public List<WeeklyMealPlan> weeklyMealPlans { get; private set; }

        public WeeklyMealPlanViewModel(List<WeeklyMealPlan> weeklymealplan)
        {
            weeklyMealPlans = weeklymealplan;
        }
    }
}
