﻿using System;
using System.Collections.Generic;
using System.Text;
using ChefPrive.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChefPrive.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<WeeklyMealPlan> WeeklyMealPlans { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
    }
}
