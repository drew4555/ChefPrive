﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using System.Security.Claims;

namespace ChefPrive.Controllers
{
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Recipes
        public async Task<IActionResult> Index(Recipe recipe)
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var client = _context.Clients.Where(c => c.ApplicationUserId == userId).FirstOrDefault();
            recipe.ClientId = client.Id;
            var clientRecipes = _context.Recipes.Where(c => c.ClientId == client.Id);
            return View(await clientRecipes.ToListAsync());
        }

        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .Include(r => r.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // GET: Recipes/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id");
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Url,MarkedAsFavorite,IsVegetarian,IsVegan,Title,ClientId")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var client = _context.Clients.Where(c => c.ApplicationUserId == userId).FirstOrDefault();
                recipe.ClientId = client.Id;
                _context.Add(recipe);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", recipe.ClientId);
            return View(recipe);
        }

        // GET: Recipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", recipe.ClientId);
            return View(recipe);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Url,MarkedAsFavorite,IsVegetarian,IsVegan,Title,ClientId")] Recipe recipe)
        {
            if (id != recipe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var client = _context.Clients.Where(c => c.ApplicationUserId == userId).FirstOrDefault();
                    var recipeFound = _context.Recipes.Where(c => c.ClientId == client.Id && recipe.Id == id).FirstOrDefault();
                    recipeFound.Id = recipe.Id;
                    recipeFound.Url = recipe.Url;
                    recipeFound.MarkedAsFavorite = recipe.MarkedAsFavorite;
                    recipeFound.IsVegetarian = recipe.IsVegetarian;
                    recipeFound.IsVegan = recipe.IsVegan;
                    recipeFound.Title = recipe.Title;
                    recipeFound.Comment = recipe.Comment;
                    recipeFound.ClientId = recipe.ClientId;
                    _context.Update(recipeFound);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeExists(recipe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", recipe.ClientId);
            return View(recipe);
        }

        // GET: Recipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .Include(r => r.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipeExists(int id)
        {
            return _context.Recipes.Any(e => e.Id == id);
        }
    }
}
