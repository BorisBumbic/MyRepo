using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsApp.Models
{
    public class NewsRepository
    {
        private readonly DatabaseContext context;

        public NewsRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public void AddNews(News news)
        {
            news.Created = DateTime.Now;
            news.Updated = DateTime.Now;
            context.Add(news);
            context.SaveChanges();
        }

        public IEnumerable<News> GetAll()
        {
            return context.News;
        }

        public News GetById(int id)
        {
            return context.News.Where(x => x.Id == id).Single();
        }

        public bool NewsExist(int id)
        {
            if (context.News.Where(x => x.Id == id).Any())
                return true;
            else
                return false;
        }

        public void Remove(int id)
        {
            var a = context.News.Where(x => x.Id == id).Single();
            context.News.Remove(a);
            context.SaveChanges();
        }

        //public void Update(News news)
        //{
        //    //fdksk
        //}

        public void RecreateDatabase()
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public int Counting()
        {
            return context.News.Count();
        }
        public void Seed()
        {
            RecreateDatabase();
            context.Add(new News
            {
                Header = "Worst Place",
                Created = DateTime.Now.AddDays(-5),
                Updated = DateTime.Now.AddDays(-5)
            });

            context.Add(new News
            {
                Header = "Grizzly Disorder",
                Created = DateTime.Now.AddDays(-3),
                Updated = DateTime.Now.AddDays(-2)

            });
            context.SaveChanges();
        }
    }
}
