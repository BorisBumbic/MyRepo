using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai
{
    public class BattleEvent
    {
        public int id { get; set; }
        public int order { get; set; }
        public string input { get; set; }
        public BattleLog battleLog { get; set; }
        public int battleLogId { get; set; }
    }
}
