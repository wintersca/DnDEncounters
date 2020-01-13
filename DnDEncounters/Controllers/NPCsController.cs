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
    public class NPCsController : Controller
    {
        private readonly DnDEncounterContext _context;

        public NPCsController(DnDEncounterContext context)
        {
            _context = context;
        }

        // GET: NPCs
        public async Task<IActionResult> Index()
        {
            return View(await _context.NPC.ToListAsync());
        }

        // GET: NPCs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nPC = await _context.NPC
                .FirstOrDefaultAsync(m => m.NPCID == id);
            if (nPC == null)
            {
                return NotFound();
            }

            return View(nPC);
        }

        // GET: NPCs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NPCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NPCID,Level,Name,Species,XP,Alignment,AC,HP,WalkSpeed,FlySpeed,SwimSpeed,Str,Dex,Con,Int,Wis,Cha,StrSave,DexSave,ConSave,IntSave,WisSave,ChaSave,PassivePerception,PassiveInsight,PassiveInvestigation,Athletics,Acrobatics,SleightOfHand,Stealth,Arcana,History,Investigation,Nature,Religion,AnimalHandling,Insight,Medicine,Perception,Survival,Deception,Intimidation,Performance,Persuasion")] NPC nPC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nPC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nPC);
        }

        // GET: NPCs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nPC = await _context.NPC.FindAsync(id);
            if (nPC == null)
            {
                return NotFound();
            }
            return View(nPC);
        }

        // POST: NPCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NPCID,Level,Name,Species,XP,Alignment,AC,HP,WalkSpeed,FlySpeed,SwimSpeed,Str,Dex,Con,Int,Wis,Cha,StrSave,DexSave,ConSave,IntSave,WisSave,ChaSave,PassivePerception,PassiveInsight,PassiveInvestigation,Athletics,Acrobatics,SleightOfHand,Stealth,Arcana,History,Investigation,Nature,Religion,AnimalHandling,Insight,Medicine,Perception,Survival,Deception,Intimidation,Performance,Persuasion")] NPC nPC)
        {
            if (id != nPC.NPCID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nPC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NPCExists(nPC.NPCID))
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
            return View(nPC);
        }

        // GET: NPCs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nPC = await _context.NPC
                .FirstOrDefaultAsync(m => m.NPCID == id);
            if (nPC == null)
            {
                return NotFound();
            }

            return View(nPC);
        }

        // POST: NPCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nPC = await _context.NPC.FindAsync(id);
            _context.NPC.Remove(nPC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NPCExists(int id)
        {
            return _context.NPC.Any(e => e.NPCID == id);
        }
    }
}
