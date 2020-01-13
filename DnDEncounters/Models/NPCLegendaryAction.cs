using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class NPCLegendaryAction
    {
        public int NPCLegendaryActionID { get; set; }

        public int LEgendaryActionID { get; set; }
        public LegendaryAction LegendaryAction { get; set; }

        public int NPCID { get; set; }
        public int NPC { get; set; }
    }
}
