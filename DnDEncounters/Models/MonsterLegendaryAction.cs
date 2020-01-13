using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class MonsterLegendaryAction
    {
        public int MonsterLegendaryActionID { get; set; }

        public int LegendaryActionID { get; set; }
        public LegendaryAction LegendaryAction { get; set; }

        public int MonsterID { get; set; }
        public Monster Monster { get; set; }
    }
}
