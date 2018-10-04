using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Onlinestore.Data;
using Onlinestore.Models;

namespace Onlinestore.Controllers
{
    public class TestiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Testies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Testy.ToListAsync());
        }

        // GET: Testies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testy = await _context.Testy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testy == null)
            {
                return NotFound();
            }

            return View(testy);
        }

        // GET: Testies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Testies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,FirstNumber,SecondNumber")] Testy testy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testy);
        }

        // GET: Testies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testy = await _context.Testy.FindAsync(id);
            if (testy == null)
            {
                return NotFound();
            }
            return View(testy);
        }

        // POST: Testies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,FirstNumber,SecondNumber")] Testy testy)
        {
            if (id != testy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestyExists(testy.Id))
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
            return View(testy);
        }

        // GET: Testies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testy = await _context.Testy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testy == null)
            {
                return NotFound();
            }

            return View(testy);
        }

        // POST: Testies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testy = await _context.Testy.FindAsync(id);
            _context.Testy.Remove(testy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestyExists(int id)
        {
            return _context.Testy.Any(e => e.Id == id);
        }
    }
}
