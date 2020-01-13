using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class NPCFeature
    {
        public int NPCFeatureID { get; set; }

        public int FeatureID { get; set; }
        public Feature Feature { get; set; }

        public int NPCID { get; set; }
        public int NPC { get; set; }
    }
}
