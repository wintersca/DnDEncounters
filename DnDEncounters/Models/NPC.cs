using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class NPC : Character
    {
        public int NPCID { get; set; }
        public int Level { get; set; }
        public ICollection<NPCAction> Actions { get; set; }
        public ICollection<NPCFeature> Features { get; set; }
        public ICollection<NPCLanguage> Languages { get; set; }
        public ICollection<NPCLegendaryAction> LegendaryActions { get; set; }
    }
}
