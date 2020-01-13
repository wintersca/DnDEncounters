using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int XP { get; set; }
        public string Alignment { get; set; }
        public int AC { get; set; }
        public int HP { get; set; }
        public int WalkSpeed { get; set; }
        public int FlySpeed { get; set; }
        public int SwimSpeed { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public int StrSave { get; set; }
        public int DexSave { get; set; }
        public int ConSave { get; set; }
        public int IntSave { get; set; }
        public int WisSave { get; set; }
        public int ChaSave { get; set; }

        // passive wis
        public int PassivePerception { get; set; }
        public int PassiveInsight { get; set; }
        // passive int
        public int PassiveInvestigation { get; set; }

        // str skills
        public int Athletics { get; set; }

        // dex skills
        public int Acrobatics { get; set; }
        public int SleightOfHand { get; set; }
        public int Stealth { get; set; }

        // int skills
        public int Arcana { get; set; }
        public int History { get; set; }
        public int Investigation { get; set; }
        public int Nature { get; set; }
        public int Religion { get; set; }

        // wis skills
        public int AnimalHandling { get; set; }
        public int Insight { get; set; }
        public int Medicine { get; set; }
        public int Perception { get; set; }
        public int Survival { get; set; }

        // cha skills
        public int Deception { get; set; }
        public int Intimidation { get; set; }
        public int Performance { get; set; }
        public int Persuasion { get; set; }

 //       public ICollection<MonsterLanguage> Languages { get; set; }
   //     public ICollection<CharacterFeature> Features { get; set; }
    }
}
