using System;
using Microsoft.AspNetCore.Mvc;

namespace Tolly.Web.Controllers
{

    public class AllInOnePlaceController : Controller
    {
        [HttpGet("AllInOnePlace")]
        public IActionResult AllInOnePlace()
        {
            try
            {
                // Läs in textfil

                string data = System.IO.File.ReadAllText("Data/bil_800kg_kl15.txt");

                // Dela upp i dess delar

                string vechicleType = data.Split(";")[0];
                int weight = int.Parse(data.Split(";")[1]);
                int hour = int.Parse(data.Split(";")[2]);

                // Beräkna pris

                double startFee = 10;
                double priceFactor = 1;

                switch (vechicleType)
                {
                    case "bil":
                        priceFactor *= 1;
                        break;
                    case "lastbil":
                        priceFactor *= 2;
                        break;
                    case "miljöbil":
                        priceFactor = 0;
                        break;
                    default: throw new Exception("Unknown vehicle type");
                }

                if (weight < 0)
                    throw new Exception("Can't have negative weight");

                if (weight > 1000)
                    priceFactor *= 1.5;

                if (hour < 0 || hour > 24)
                    throw new Exception("Invalid hour");

                if (hour >= 8 && hour <= 17)
                    priceFactor *= 1.2;

                double totalPrice = startFee * priceFactor;

                // Svara

                return Ok($"Vägtullavgift för en {vechicleType} med vikten {weight}kg klockan {hour} är {totalPrice}kr");
            }
            catch (Exception ex)
            {
                return BadRequest("Oväntat fel: " + ex.Message);
            }
        }
    }
}
