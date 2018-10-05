using System;
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

            _newsRepository.RecreateDatabase();

            News news1 = new News
            {
                Header = "worst place",
                CreatDatTime = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            News news2 = new News
            {
                Header = "Grizzly restored",
                CreatDatTime = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            _newsRepository.Add(news1);
            _newsRepository.Add(news2);


            return Ok();

           
        }

        [HttpPost("recreate")]
        public IActionResult RecreateDatabase()
        {
            _newsRepository.RecreateDatabase();
            return Ok();
        }

        [HttpGet("count")] // api/news/count
        public IActionResult Count()
        {
            int a = _newsRepository.Count();
            return Ok(a);
           
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var v=_newsRepository.GetAll();
            return Ok(v);
          
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Add([FromBody]News news)
        {
            news.CreatDatTime = DateTime.Now;
            news.UpdatedDate = DateTime.Now;
            _newsRepository.Add(news);
           

            return Ok(news.Id);
        }

        [HttpPut]
        public IActionResult Update([FromBody]News news)
        { 
            news.UpdatedDate= DateTime.Now;
            _newsRepository.Update(news);
            
           
            return Ok(news.Id);

           
        }

        [HttpDelete("{id}")] // api/news/123 DELETE
        public IActionResult Remove(int id)
        {
            _newsRepository.Remove(id);
            return Ok();
        }

    }
}
