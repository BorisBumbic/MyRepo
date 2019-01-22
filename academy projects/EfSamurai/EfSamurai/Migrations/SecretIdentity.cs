using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai
{
    public class SecretIdentity
    {
        public string name { get; set; }
        public Samurai samurai { get; set; }
        public int id { get; set; }
        public int samuraiId { get; set; }
    }
}
