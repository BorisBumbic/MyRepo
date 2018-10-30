using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onlinestore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> List { get; set; }
    }
}
