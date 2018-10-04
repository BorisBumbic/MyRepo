using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onlinestore.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Pow()
        {
            return View();
        }

        public IActionResult Age()
        {
            return Ok(17);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TopFive()
        {
            return View();
        }
   }
}
