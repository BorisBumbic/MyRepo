using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spaceship_checkpoint
{
    public class SpaceContext : DbContext
    {
        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<Ravioli> RavioliSupply { get; set; } 


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = Spaceship;");
        }
    }
}
