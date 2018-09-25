using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("WebApi1")]
    public class WebApiController : Controller
    {
        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;

            }
            Planet planet = new Planet
            {
                Name = formContent.Split("=")[1].Split("&")[0],
                Size = int.Parse(formContent.Split("=")[2])
            };

            return Ok($"Ny planet {planet.Name} med storleken {planet.Size} är tillagd.");
        }



        [Route("GetPlanet")]
        public IActionResult GetPlanet()
        {
            var formContent = Request.QueryString.Value;
            

            Planet planet = new Planet
            {
                Name = formContent.Split("=")[1].Split("&")[0],
                Size = int.Parse(formContent.Split("=")[2])
            };

            return Ok($"Vår planet: {planet.Name} är {planet.Size} stor.");
        }
    }

}
