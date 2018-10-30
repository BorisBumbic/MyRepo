using System;
using Microsoft.AspNetCore.Mvc;
using Tolly.Domain.Models;
using Tolly.Domain.Services;

namespace Tolly.Web.Controllers
{

    public class HomeController : Controller
    {
        private readonly ITollCalculator _tollCalculator;

        public HomeController(ITollCalculator tollCalculator)
        {
            _tollCalculator = tollCalculator;
        }

        [HttpGet("Calc")]
        public IActionResult Calc(string item)
        {
            try
            {
                ResultFromCalculation result = _tollCalculator.Calculate(item);

                return Ok($"Vägtullavgift för en {result.VehicleType} med vikten {result.Weight}kg klockan {result.Hour} är {result.TotalPrice}kr");
            }
            catch (Exception ex)
            {
                return BadRequest("Oväntat fel: " + ex.Message);
            }
        }
    }
}
