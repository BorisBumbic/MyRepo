using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai
{
    public class SamuraisToBattle
    {
        public int samuraiId { get; set; }
        public Samurai Samurai { get; set; }

        public int battleId { get; set; }
        public Battle battle { get; set; }
    }
}
