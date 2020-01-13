using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDEncounters.Models
{
    public class MonsterAction
    {
        public int MonsterActionID { get; set; }

        public int StandardActionID { get; set; }
        public StandardAction StandardAction { get; set; }

        public int MonsterID { get; set; }
        public Monster Monster { get; set; }
    }
}
