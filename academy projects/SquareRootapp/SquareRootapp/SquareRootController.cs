using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquareRootapp
{
    public class SquareRootController : Controller
    {
        [HttpGet("api/squareroot")]
        public IActionResult SquareRoot(int? number, int? dec)
        {
            if (number == null)
                return BadRequest("Ange ett tal!");

            if (number < 0)
                return BadRequest("Talet måste vara större än 0!");

            return Ok(Math.Round(Math.Sqrt((int)number), (int)dec));
        }
    }
}
