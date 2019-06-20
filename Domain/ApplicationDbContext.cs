using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public class ApplicationUser : IdentityUser
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipes> Recipess { get; set; }
        //public DbSet<WeeklyMealPlan> WeeklyMealPlans { get; set; }
        public DbSet<ClientIngredient> ClientIngredients { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
    }
}
