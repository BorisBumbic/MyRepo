using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Onlinestore.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Namn krävs!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Hallå! Fyll i!")]
        [Range(0, 1000, ErrorMessage ="Det måste vara mellan 0 och 1000")]
        //[RegularExpression("[0-9]*", ErrorMessage ="FEL!!")]
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
