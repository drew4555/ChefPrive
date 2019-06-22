using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace ChefPrive.Controllers
{
    public class ClientIngredientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientIngredientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClientIngredients
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ClientIngredients.Include(c => c.Client).Include(c => c.Ingredient);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ClientIngredients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientIngredient = await _context.ClientIngredients
                .Include(c => c.Client)
                .Include(c => c.Ingredient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientIngredient == null)
            {
                return NotFound();
            }

            return View(clientIngredient);
        }

        // GET: ClientIngredients/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id");
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Id");
            return View();
        }

        // POST: ClientIngredients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClientId,IngredientId")] ClientIngredient clientIngredient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientIngredient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", clientIngredient.ClientId);
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Id", clientIngredient.IngredientId);
            return View(clientIngredient);
        }

        // GET: ClientIngredients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientIngredient = await _context.ClientIngredients.FindAsync(id);
            if (clientIngredient == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", clientIngredient.ClientId);
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Id", clientIngredient.IngredientId);
            return View(clientIngredient);
        }

        // POST: ClientIngredients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClientId,IngredientId")] ClientIngredient clientIngredient)
        {
            if (id != clientIngredient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientIngredient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientIngredientExists(clientIngredient.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", clientIngredient.ClientId);
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Id", clientIngredient.IngredientId);
            return View(clientIngredient);
        }

        // GET: ClientIngredients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientIngredient = await _context.ClientIngredients
                .Include(c => c.Client)
                .Include(c => c.Ingredient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientIngredient == null)
            {
                return NotFound();
            }

            return View(clientIngredient);
        }

        // POST: ClientIngredients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientIngredient = await _context.ClientIngredients.FindAsync(id);
            _context.ClientIngredients.Remove(clientIngredient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientIngredientExists(int id)
        {
            return _context.ClientIngredients.Any(e => e.Id == id);
        }
    }
}
