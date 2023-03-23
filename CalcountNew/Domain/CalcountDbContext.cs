using MauiApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calcount.Domain
{
    public class CalcountDbContext : DbContext
    {
        public DbSet<Meal> Meals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\yaros\source\repos\CalcountNew\CalcountNew\calcount.db;", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meal>().ToTable("Meals");
            modelBuilder.Entity<Meal>(entity =>
            {
                entity.HasKey(entity => entity.Id);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
