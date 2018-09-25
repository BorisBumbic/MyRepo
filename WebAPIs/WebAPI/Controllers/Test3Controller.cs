using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using System.Text;



namespace WebAPI.Controllers
{
    [Route("test3")]
    public class Test3Controller : Controller
    {
        [HttpPost("frukost")]
        public IActionResult Frukost()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }

            string måltid = formContent.Split("=")[1];
            string svar = "";

            if (måltid == "egg")
                svar = "Det är inte bra att äta ägg till frukost.";
            else
                svar = $"{måltid}! Vad nyttigt!";

            return Ok(svar);

        }

        [HttpPost("kvadrat")]
        public IActionResult Kvadrat()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                formContent = reader.ReadToEndAsync().Result;

            int input = int.Parse(formContent.Split("=")[1]);
            int output = input * input;

            return Ok($"{input} * {input} = {output}");
        }

        [HttpPost("lista")]
        public IActionResult Lista()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                formContent = reader.ReadToEndAsync().Result;

            int a = int.Parse(formContent.Split("=")[1].Split("&")[0]);
            int b = int.Parse(formContent.Split("=")[2]);
            var c = new List<int>();

            for (int i = a; i < b; i++)
            {
                c.Add(i);
            }

            return Ok(c);
        }
}
}
