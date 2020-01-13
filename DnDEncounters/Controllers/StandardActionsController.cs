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
    public class StandardActionsController : Controller
    {
        private readonly DnDEncounterContext _context;

        public StandardActionsController(DnDEncounterContext context)
        {
            _context = context;
        }

        // GET: StandardActions
        public async Task<IActionResult> Index()
        {
            return View(await _context.StandardAction.ToListAsync());
        }

        // GET: StandardActions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var standardAction = await _context.StandardAction
                .FirstOrDefaultAsync(m => m.StandardActionID == id);
            if (standardAction == null)
            {
                return NotFound();
            }

            return View(standardAction);
        }

        // GET: StandardActions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StandardActions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StandardActionID,Description")] StandardAction standardAction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(standardAction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(standardAction);
        }

        // GET: StandardActions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var standardAction = await _context.StandardAction.FindAsync(id);
            if (standardAction == null)
            {
                return NotFound();
            }
            return View(standardAction);
        }

        // POST: StandardActions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StandardActionID,Description")] StandardAction standardAction)
        {
            if (id != standardAction.StandardActionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(standardAction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StandardActionExists(standardAction.StandardActionID))
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
            return View(standardAction);
        }

        // GET: StandardActions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var standardAction = await _context.StandardAction
                .FirstOrDefaultAsync(m => m.StandardActionID == id);
            if (standardAction == null)
            {
                return NotFound();
            }

            return View(standardAction);
        }

        // POST: StandardActions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var standardAction = await _context.StandardAction.FindAsync(id);
            _context.StandardAction.Remove(standardAction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StandardActionExists(int id)
        {
            return _context.StandardAction.Any(e => e.StandardActionID == id);
        }
    }
}
