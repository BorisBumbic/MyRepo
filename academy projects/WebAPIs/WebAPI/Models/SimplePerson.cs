using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class SimplePerson
    {
        [Required(ErrorMessage = "Namnet på personen är obligatoriskt!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Åldern på personen är obligatorisk!")]
        public int Age { get; set; }
    }
}
