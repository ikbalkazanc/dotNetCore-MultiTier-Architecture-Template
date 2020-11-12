using Core.Models;
using Data.Configuration;
using Data.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguraiton());
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1,2,3,4}));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1,2,3 }));
            modelBuilder.ApplyConfiguration(new PersonSeed(new int[] { 1, 2 }));
        }
    }
}
