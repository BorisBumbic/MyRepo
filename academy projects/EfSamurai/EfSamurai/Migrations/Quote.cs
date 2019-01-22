using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai
{
    public class Quote
    {
        public int id { get; set; }
        public string text { get; set; }
        public Samurai owner { get; set; }
        public SortOfQuote sort { get; set; }
    }
}
