using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Onlinestore.Models;

namespace Onlinestore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Onlinestore.Models.Product> Product { get; set; }
        public DbSet<Onlinestore.Models.Testy> Testy { get; set; }
        public DbSet<Onlinestore.Models.Category> Category { get; set; }
    }
}
