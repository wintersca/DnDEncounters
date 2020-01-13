using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class MonsterFeature
    {
        public int MonsterFeatureID { get; set; }

        public int FeatureID { get; set; }
        public Feature Feature { get; set; }

        public int MonsterID { get; set; }
        public Monster Monster { get; set; }
    }
}
