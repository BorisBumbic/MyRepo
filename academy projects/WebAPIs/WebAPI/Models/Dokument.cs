using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Dokument
    {
        [Required(ErrorMessage = "Age is required!")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Adress is required!")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Please specify your gender.")]
        public Gender? Gender { get; set; }
        [Required(ErrorMessage ="Please fill in the hand in date!")]
        public DateTime? HandInDate { get; set; }
        [Required(ErrorMessage = "Please state which school you attend!")]
        public School? School { get; set; }
        public bool IsPostdoc { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public enum School
    {
        SU,
        KTH
    }
}
