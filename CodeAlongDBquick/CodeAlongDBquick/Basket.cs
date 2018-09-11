using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAlongDBquick
{
    public class Basket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BasketToFruit BTF { get; set; }
    }
}
