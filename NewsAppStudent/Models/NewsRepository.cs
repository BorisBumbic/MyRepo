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

        public void Add(News news)
        {
            context.Add(news);
            context.SaveChanges();
        }

        public IEnumerable<News> GetAll()
        {
            return context.News.ToList();
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
            News n = context.News.Single(x=>x.Id == id);

            context.Remove(n);
            context.SaveChanges();
        }

        public void Update(News news)
        {
            context.Update(news);
            context.SaveChanges();

            
        }

        public void RecreateDatabase()
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public int Count()
        {
            return context.News.Count();
        }
    }
}
