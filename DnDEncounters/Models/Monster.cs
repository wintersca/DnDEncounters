using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class Monster : Character
    {        
        public int MonsterID { get; set; }
        public int CR { get; set; }
        public ICollection<MonsterAction> Actions { get; set; }
        public ICollection<MonsterFeature> Features { get; set; }        
        public ICollection<MonsterLanguage> Languages { get; set; }
        public ICollection<MonsterLegendaryAction> LegendaryActions { get; set; }

    }
}
