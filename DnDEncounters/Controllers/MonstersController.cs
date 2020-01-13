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
    public class MonstersController : Controller
    {
        private readonly DnDEncounterContext _context;

        public MonstersController(DnDEncounterContext context)
        {
            _context = context;
        }

        // GET: Monsters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Monster.ToListAsync());
        }

        // GET: Monsters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monster
                .FirstOrDefaultAsync(m => m.MonsterID == id);
            if (monster == null)
            {
                return NotFound();
            }

            return View(monster);
        }

        // GET: Monsters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monsters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MonsterID,CR,Name,Species,XP,Alignment,AC,HP,WalkSpeed,FlySpeed,SwimSpeed,Str,Dex,Con,Int,Wis,Cha,StrSave,DexSave,ConSave,IntSave,WisSave,ChaSave,PassivePerception,PassiveInsight,PassiveInvestigation,Athletics,Acrobatics,SleightOfHand,Stealth,Arcana,History,Investigation,Nature,Religion,AnimalHandling,Insight,Medicine,Perception,Survival,Deception,Intimidation,Performance,Persuasion")] Monster monster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monster);
        }

        // GET: Monsters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monster.FindAsync(id);
            if (monster == null)
            {
                return NotFound();
            }
            return View(monster);
        }

        // POST: Monsters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MonsterID,CR,Name,Species,XP,Alignment,AC,HP,WalkSpeed,FlySpeed,SwimSpeed,Str,Dex,Con,Int,Wis,Cha,StrSave,DexSave,ConSave,IntSave,WisSave,ChaSave,PassivePerception,PassiveInsight,PassiveInvestigation,Athletics,Acrobatics,SleightOfHand,Stealth,Arcana,History,Investigation,Nature,Religion,AnimalHandling,Insight,Medicine,Perception,Survival,Deception,Intimidation,Performance,Persuasion")] Monster monster)
        {
            if (id != monster.MonsterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonsterExists(monster.MonsterID))
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
            return View(monster);
        }

        // GET: Monsters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monster
                .FirstOrDefaultAsync(m => m.MonsterID == id);
            if (monster == null)
            {
                return NotFound();
            }

            return View(monster);
        }

        // POST: Monsters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monster = await _context.Monster.FindAsync(id);
            _context.Monster.Remove(monster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonsterExists(int id)
        {
            return _context.Monster.Any(e => e.MonsterID == id);
        }
    }
}
