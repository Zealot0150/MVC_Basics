using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Basics.Models
{

    // Bara för mitt dåliga minne
//    get-help Add-Migration
//and

//get-help Update-Database


    public class AppDbContext : DbContext
    {
        public DbSet<Crab> Crabs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<People> People { get; set; }


        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // körs vid start behövs när man inte har startup config
        //    // denna är olika för varje lev så vid nuget pack mysql=> UseMySql
        //    optionsBuilder.UseSqlServer(Configurationsstring);
        //    base.OnConfiguring(optionsBuilder);
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 1, Name = "Red Crabs" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 2, Name = "Brown Crabs" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 3, Name = "Blue Crabs" });
            _ = modelBuilder.Entity<Crab>().HasData(new Crab
            {
                CrabID = 1,
                Name = "Brown Crab",
                Description = "Description brown crab",
                Price = 1.0,
                ImageUrl = "https://images.unsplash.com/photo-1615834751896-b15e2330b289?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1434&q=80",
                CategoryID = 1,
                IsCrabOfTheWeek = true
            });
            _ = modelBuilder.Entity<Crab>().HasData(new Crab
            {
                CrabID = 2,
                Name = "Blue Crab",
                Description = "Description bluecrab",
                Price = 2.0,
                ImageUrl = "https://images.unsplash.com/photo-1509415173911-37ff7a1aa29c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1135&q=80",
                CategoryID = 2,
                IsCrabOfTheWeek = false
            });

            _ = modelBuilder.Entity<Crab>().HasData(new Crab
            {
                CrabID = 3,
                Name = "Red Crab",
                Description = "Description bluecrab",
                Price = 3.0,
                ImageUrl = "https://images.unsplash.com/photo-1580841129862-bc2a2d113c45?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2073&q=80",
                CategoryID = 3,
                IsCrabOfTheWeek = false
            });
            _ = modelBuilder.Entity<Crab>().HasData(new Crab
            {
                CrabID = 4,
                Name = "Browner Crab",
                Description = "Description brown crab",
                Price = 4.0,
                ImageUrl = "https://images.unsplash.com/photo-1615834751896-b15e2330b289?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1434&q=80",
                CategoryID = 1,
                IsCrabOfTheWeek = false
            });
            _ = modelBuilder.Entity<Crab>().HasData(new Crab
            {
                CrabID = 5,
                Name = "Bluer Crab",
                Description = "Description bluercrab",
                Price = 5.0,
                ImageUrl = "https://images.unsplash.com/photo-1509415173911-37ff7a1aa29c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1135&q=80",
                CategoryID = 2,
                IsCrabOfTheWeek = false
            });

            _ = modelBuilder.Entity<Crab>().HasData(new Crab
            {
                CrabID = 6,
                Name = "Reder Crab",
                Description = "Description bluecrab",
                Price = 6.0,
                ImageUrl = "https://images.unsplash.com/photo-1580841129862-bc2a2d113c45?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2073&q=80",
                CategoryID = 3,
                IsCrabOfTheWeek = false
            });

            modelBuilder.Entity<People>().HasData(new People { Id = 1, Name = "Fjollan", Tele= "0701234567", City="Malmo"});
            modelBuilder.Entity<People>().HasData(new People { Id = 2, Name = "Stumpan", Tele= "070111111", City="Gbg"});
            modelBuilder.Entity<People>().HasData(new People { Id = 3, Name = "Rumpan", Tele= "070121221", City="Stackholm"});

        }

    }
}
