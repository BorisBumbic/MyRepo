using Microsoft.AspNetCore.Mvc;
using Onlinestore.Models;
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
            var stringService = new Common.services.StringService();

            string s = "Hejsan på dejsan din gamle galosch!";
            string a = stringService.CutString(s, 30);
            return View(a);
        }

        public IActionResult TopFive()
        {
            return View();
        }
    }
}
