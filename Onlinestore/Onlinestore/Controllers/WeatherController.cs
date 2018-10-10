using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onlinestore.Models;
using Onlinestore.Viewservice;

namespace Onlinestore.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index(WeatherViewModels vm)
        {
                vm.Latitude = 59.0M;
                vm.Longitude = 17.9M;

            return View(vm);
        }

        public IActionResult GetWeather(WeatherViewModels vm)
        {
            var smhiService = new SmhiServices();
            Rootobject result = smhiService.GetMeteorologicalForecast(vm.Longitude, vm.Latitude);

            List<TimeTemp> list = smhiService.FilterTemperature(result, vm.TimeTemps[0].Time);

            vm.TimeTemps = smhiService.FilterTemperature(result, DateTime.Now);

            //vm.TimeTemps = new List<TimeTemp>();

            //vm.TimeTemps.Add(new TimeTemp { Temp = 18, Time = DateTime.Now });
            //vm.TimeTemps.Add(new TimeTemp { Temp = 16, Time = DateTime.Now });
            return View("Index", vm);

        }
    }
}