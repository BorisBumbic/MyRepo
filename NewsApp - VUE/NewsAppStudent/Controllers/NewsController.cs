using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Models;

namespace NewsApp.Controllers
{
    [Route("api/news")]
    public class NewsController : Controller
    {
        private NewsRepository _newsRepository;

        public NewsController(NewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        [HttpPost("seed")]
        public IActionResult Seed()
        {
            _newsRepository.Seed();
            return Ok("Database seeded!");
        }

        [HttpPost("recreate")]
        public IActionResult RecreateDatabase()
        {
            _newsRepository.Seed();
            return Ok();
        }

        [HttpGet("count")]
        public IActionResult Counter()
        {
            int a = _newsRepository.Counting();
            return Ok(a);
        }

        [HttpGet("getall")] // api/news GET
        public IActionResult GetAll()
        {
            var a = _newsRepository.GetAll();
            return Ok(a);
        }

        //[HttpGet("getbyid")]
        //public IActionResult GetById(int id)
        //{
        //    var a = _newsRepository.GetById(id);
        //    return Ok(a);
        //}

        [HttpPost("add")]
        public IActionResult Add([FromBody]News news)
        {
            _newsRepository.AddNews(news);
            return Ok($"{news.Header} added with id {news.Id}");
        }

        //[HttpPut]
        //public IActionResult Update([FromBody]News news)
        //{
        //    IEnumerable<News> a = _newsRepository.GetAll();
        //    return Ok(a);
        //}

        //[HttpDelete]
        //public IActionResult Remove(int id)
        //{
        //    _newsRepository.Remove(id);
        //    return Ok($"Post with id {id} succesfully removed.");
        //}
    }
}
