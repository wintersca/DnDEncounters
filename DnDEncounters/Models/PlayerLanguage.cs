using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class PlayerLanguage
    {
        public int PlayerLanguageID { get; set; }

        public int LanguageID { get; set; }
        public Language Language;

        public int PlayerID{ get; set; }
        public Player Player;
    }
}
