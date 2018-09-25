using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("test")]
    public class Test2Controller : Controller
    {
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            Random r = new Random();
            int a = r.Next(1, 3);
            string b = "";
            if (a == 1)
                b = "Hello World!";
            else if (a == 2)
                b = "Hola Mundo!";
            else
                b = "Hejsan på dejsan!";

            return Ok(b);
        }

        [HttpGet("datum")]
        public IActionResult Datum()
        {
            return Ok($"Idag är det {DateTime.Today.DayOfWeek}. För tio år sen var det {DateTime.Today.AddYears(-10).DayOfWeek}");
        }

        [HttpGet("floskel")]
        public IActionResult Floskel()
        {
            return Ok("Carpe diem");
        }

    }
}
