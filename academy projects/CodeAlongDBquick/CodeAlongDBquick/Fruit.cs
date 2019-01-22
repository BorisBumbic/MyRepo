using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAlongDBquick
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal? Price { get; set; }
        public string Colour { get; set; }
        public FruitCategories Bosse { get; set; }
        public BasketToFruit Basketty { get; set; }
    }
}
