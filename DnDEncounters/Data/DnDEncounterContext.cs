using DnDEncounters.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Data
{
    public class DnDEncounterContext : DbContext
    {
        public DnDEncounterContext (DbContextOptions<DnDEncounterContext> options) : base(options)
        {

        }
                
        public DbSet<Monster> Monster { get; set; }
        public DbSet<NPC> NPC { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<DnDEncounters.Models.StandardAction> StandardAction { get; set; }
        public DbSet<DnDEncounters.Models.Feature> Feature { get; set; }
        public DbSet<DnDEncounters.Models.Language> Language { get; set; }
        public DbSet<DnDEncounters.Models.LegendaryAction> LegendaryAction { get; set; }
        
    }
}
