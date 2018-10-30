using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai
{
    public class Samurai
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Quote> quoteList { get; set; }
        public Haircut haircut { get; set; }
        public SecretIdentity identity { get; set; }
        public List<SamuraisToBattle> stb { get; set; }
    }
}
