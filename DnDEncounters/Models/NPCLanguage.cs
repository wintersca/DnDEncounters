using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class NPCLanguage
    {
        public int NPCLanguageID { get; set; }

        public int LanguageID { get; set; }
        public Language Language { get; set; }

        public int NPCID { get; set; }
        public NPC NPC { get; set; }
    }
}
