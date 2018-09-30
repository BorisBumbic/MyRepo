using System;
using BirdWatcher.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BirdWatcher.Web.Controllers
{
    [Route("observation")]
    public class ObservationController : Controller
    {
        private readonly Repository _repo;

        public ObservationController(Repository repo)
        {
            _repo = repo;
        }

        [HttpPost("recreate")]
        public IActionResult RecreateDatabase()
        {
            _repo.RecreateDatabase();
            return Ok();
        }

        [HttpPost("addy")]
        public IActionResult Add([FromBody]Observation observation)
        {
            _repo.Add(observation);
            return Ok("Observation added");
        }

        [HttpGet("getty")]
        public IActionResult GetAll()
        {
            var a = _repo.GetAll();
            return Ok("List fetched!");

        }

    }
}
