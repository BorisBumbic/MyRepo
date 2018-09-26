using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("test6")]
    public class Test6Controller : Controller
    {
        [HttpPost("popDoc")]
        public IActionResult SubmitForm(Dokument doc)
        {
            bool yesNo = ModelState.IsValid;

            if (yesNo == false)
                return BadRequest(ModelState);
            else
                return Ok(doc);
        }
    }
}
