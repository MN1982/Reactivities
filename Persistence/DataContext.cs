using System;
using Microsoft.EntityFrameworkCore;
using Domain;



namespace  Persistence
{
    public class DataContext : DbContext
    {
        //constructor for 
        public DataContext(DbContextOptions options) :base(options)
        {
            
        }

        public DbSet<value> values { get; set; }

        protected override void  OnModelCreating(ModelBuilder builder)
        {
             builder.Entity<value>()
             .HasData(
                  new value {Id=1 , Name="Najmi"},
                  new value {Id=2 , Name="Nasiri"},
                  new value {Id=3 , Name="Farmani"}
             );

        }

    }
}