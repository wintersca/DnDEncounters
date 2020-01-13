using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class Player : Character
    {
        public int PlayerID { get; set; }
        public int Level { get; set; }
        public int ProficiencyBonus { get; set; }
        public ICollection<PlayerLanguage> Languages { get; set; }
    }
}
