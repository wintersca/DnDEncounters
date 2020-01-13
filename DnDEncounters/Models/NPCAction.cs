using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class NPCAction
    {
        public int NPCActionID { get; set; }

        public int StandardActionID { get; set; }
        public StandardAction StandardAction { get; set; }

        public int NPCID { get; set; }
        public int NPC { get; set; }
    }
}
