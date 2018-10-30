using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAlongDBquick
{
    class FruitContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            if (!optionsbuilder.IsConfigured)
                optionsbuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database = EfTest;");
        }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasketToFruit>().HasKey(x => new { x.BasketId, x.FruitId });
        }
    }
}
