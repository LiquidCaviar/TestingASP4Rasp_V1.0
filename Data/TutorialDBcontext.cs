using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingASP4Rasp_V1._0.Data.Entities;

namespace TestingASP4Rasp_V1._0.Data
{
    public class TutorialDBcontext:DbContext
    {
        public TutorialDBcontext(DbContextOptions<TutorialDBcontext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
               .HasData(new Order
               {

               });
        }

    }
}
