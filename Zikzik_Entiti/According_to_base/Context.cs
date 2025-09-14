using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zikzik_Domain.Models;

namespace Zikzik_Entiti.According_to_base
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User { id = new Guid("027027a5-8718-4cb6-8fad-3dc4f76e50eb"), User_name = "Tom", Age = 23, contry = "Rassuan" },
                    new User { id = new Guid("59422700-841d-45d5-ae98-382712c8b8ed"), User_name = "Alice", Age = 26, contry = "USA" },
                    new User { id = new Guid("ee49958b-f023-4b04-a17e-bfd7ccecf850"), User_name = "Sam", Age = 28, contry = "German" }
            );
        }
        public DbSet<User> users { get; set; }
    }
}
