using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onlinestore.Models
{
    public class WeatherViewModels
    {
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public List<TimeTemp> TimeTemps { get; set; }
        public string ErrorMessage { get; set; }
    }

}
