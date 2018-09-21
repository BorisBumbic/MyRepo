using System;
using System.Collections.Generic;
using System.Text;

namespace Spaceship_checkpoint
{
    public class Ravioli
    {
        public int id { get; set; }
        public int Quantity { get; set; }
        public DateTime packDate { get; set; }
        public DateTime expDate { get; set; }
        public Spaceship Spaceship { get; set; }
    }
}
