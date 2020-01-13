using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class MonsterLanguage
    {
        public int MonsterLanguageID { get; set; }

        public int LanguageID { get; set; }
        public Language Language { get; set; }

        public int MonsterID { get; set; }
        public Monster Monster { get; set; }
    }
}
