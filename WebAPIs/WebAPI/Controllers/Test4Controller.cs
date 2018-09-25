using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("test4")]
    public class Test4Controller : Controller
    {
        [HttpPost("choklad")]
        public IActionResult DelaKaka(int choklad)
        {
            if (choklad < 1)
                return BadRequest("Talet är mindre än 1!");
            else
            {
                int division = 24 / choklad;
                return Ok("Ni är " + choklad + " som delar på kakan. Alla får " + division + " var.");
            }
        }

        [HttpPost("order")]
        public IActionResult GetOrder(string input)
        {
            
            Regex reggie = new Regex(@"[a-zA-Z]{3}-\d{4}");
            Match match = reggie.Match(input);

            if (!match.Success)
                return BadRequest("Din input är av fel format!");

            int firstTest = int.Parse(input.Split("-")[1]);
            if (firstTest > 3000)
                return BadRequest("Din order existerar inte.");

            return Ok($"Ordernummer {input} hittad!");
        }

    }
}
