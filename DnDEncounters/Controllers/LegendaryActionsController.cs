using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DnDEncounters.Data;
using DnDEncounters.Models;

namespace DnDEncounters.Controllers
{
    public class LegendaryActionsController : Controller
    {
        private readonly DnDEncounterContext _context;

        public LegendaryActionsController(DnDEncounterContext context)
        {
            _context = context;
        }

        // GET: LegendaryActions
        public async Task<IActionResult> Index()
        {
            return View(await _context.LegendaryAction.ToListAsync());
        }

        // GET: LegendaryActions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legendaryAction = await _context.LegendaryAction
                .FirstOrDefaultAsync(m => m.LegendaryActionId == id);
            if (legendaryAction == null)
            {
                return NotFound();
            }

            return View(legendaryAction);
        }

        // GET: LegendaryActions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LegendaryActions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LegendaryActionId,Description")] LegendaryAction legendaryAction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(legendaryAction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(legendaryAction);
        }

        // GET: LegendaryActions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legendaryAction = await _context.LegendaryAction.FindAsync(id);
            if (legendaryAction == null)
            {
                return NotFound();
            }
            return View(legendaryAction);
        }

        // POST: LegendaryActions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LegendaryActionId,Description")] LegendaryAction legendaryAction)
        {
            if (id != legendaryAction.LegendaryActionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(legendaryAction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LegendaryActionExists(legendaryAction.LegendaryActionId))
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
            return View(legendaryAction);
        }

        // GET: LegendaryActions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legendaryAction = await _context.LegendaryAction
                .FirstOrDefaultAsync(m => m.LegendaryActionId == id);
            if (legendaryAction == null)
            {
                return NotFound();
            }

            return View(legendaryAction);
        }

        // POST: LegendaryActions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var legendaryAction = await _context.LegendaryAction.FindAsync(id);
            _context.LegendaryAction.Remove(legendaryAction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LegendaryActionExists(int id)
        {
            return _context.LegendaryAction.Any(e => e.LegendaryActionId == id);
        }
    }
}
