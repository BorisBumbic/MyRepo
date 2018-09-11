using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAlongDBquick
{
    public class BasketToFruit
    {
        public int FruitId { get; set; }
        public List<Fruit> FruitList { get; set; }

        public int BasketId { get; set; }
        public List<Basket> BasketList { get; set; } 
    }
}
