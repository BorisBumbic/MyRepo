using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAlongDBquick
{
    public class FruitCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Fruit> FruitList { get; set; }

    }
}
