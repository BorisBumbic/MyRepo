using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai
{
    public class Battle
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool brutal { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<SamuraisToBattle> stb { get; set; }
        public BattleLog log { get; set; }
        public int battleLogId { get; set; }
    }
}
