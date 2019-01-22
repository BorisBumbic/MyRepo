using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("test5")]
    public class Test5Controller : Controller
    {
        [HttpPost("persform")]
        public IActionResult AddPers(SimplePerson adam)
        {
            bool yesNo = ModelState.IsValid;
            if (yesNo == false)
                return BadRequest(ModelState);
            else
            return Ok($"Personen {adam.Name} med ålder {adam.Age} har lagts till i databasen.");
        }
    }
}
