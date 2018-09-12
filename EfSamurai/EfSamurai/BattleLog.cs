using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai
{
    public class BattleLog
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<BattleEvent> battleEvents { get; set; }

    }
}
