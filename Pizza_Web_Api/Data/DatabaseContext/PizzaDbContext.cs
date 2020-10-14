using Domain_Models.Enums;
using Domain_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DatabaseContext
{
    public partial class PizzaDbContext : DbContext
    {
        public PizzaDbContext()
        {
        }

        public PizzaDbContext(DbContextOptions<PizzaDbContext> options)
            : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    FirstName = "Vaska",
                    LastName = "Vasileva",
                    Address = "Address1",
                    Phone = 070264353,
                    Username = "Vaska123",
                    Password = "123vaska123",
                    OrderIds = {1,2}
                },
                new User()
                {
                    FirstName = "Goce",
                    LastName = "Kabov",
                    Address = "Address2",
                    Phone = 071585969,
                    Username = "GoceK456",
                    Password = "456goce456",
                    OrderIds = {3}
                },
                new User()
                {
                    FirstName = "Darko",
                    LastName = "Panchevski",
                    Address = "Address3",
                    Phone = 075742394,
                    Username = "DareP789",
                    Password = "789dare789",
                    OrderIds = {4,5}
                }
                );

            modelBuilder.Entity<Pizza>().HasData(
                new Pizza()
                {
                    Name = "PassionPizza",
                    Size = PizzaSize.Small,
                    IngredientIds = { 1, 5, 6, 8 }
                },
                new Pizza()
                {
                    Name = "PassionPizza",
                    Size = PizzaSize.Medium,
                    IngredientIds = { 2, 5, 6, 8 }
                },
                new Pizza()
                {
                    Name = "PassionPizza",
                    Size = PizzaSize.Large,
                    IngredientIds = { 3, 5, 6, 8 }
                },
                new Pizza()
                {
                    Name = "PassionPizza",
                    Size = PizzaSize.Family,
                    IngredientIds = { 4, 5, 6, 8 }
                },
                new Pizza()
                {
                    Name = "DifferentPizza",
                    Size = PizzaSize.Small,
                    IngredientIds = { 1, 5, 6, 7, 8 }
                },
                new Pizza()
                {
                    Name = "DifferentPizza",
                    Size = PizzaSize.Medium,
                    IngredientIds = { 2, 5, 6, 7, 8 }
                },
                new Pizza()
                {
                    Name = "DifferentPizza",
                    Size = PizzaSize.Large,
                    IngredientIds = { 3, 5, 6, 7, 8 }
                },
                new Pizza()
                {
                    Name = "DifferentPizza",
                    Size = PizzaSize.Family,
                    IngredientIds = { 4, 5, 6, 7, 8 }
                }
                );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    Name = "StandardDoughSmall",
                    Type = IngredientType.Dough,
                    Weight = 50,
                    Price = 50
                },
                new Ingredient()
                {
                    Name = "StandardDoughMedium",
                    Type = IngredientType.Dough,
                    Weight = 60,
                    Price = 80
                },
                new Ingredient()
                {
                    Name = "StandardDoughLarge",
                    Type = IngredientType.Dough,
                    Weight = 70,
                    Price = 110
                },
                new Ingredient()
                {
                    Name = "StandardDoughFamily",
                    Type = IngredientType.Dough,
                    Weight = 80,
                    Price = 150
                },
                new Ingredient()
                {
                    Name = "Peperoni",
                    Type = IngredientType.Meat,
                    Weight = 40,
                    Price = 50
                },
                new Ingredient()
                {
                    Name = "Mushrooms",
                    Type = IngredientType.Other,
                    Weight = 50,
                    Price = 70
                },
                new Ingredient()
                {
                    Name = "Chedar",
                    Type = IngredientType.Cheese,
                    Weight = 60,
                    Price = 110
                },
                new Ingredient()
                {
                    Name = "MozarellaCheese",
                    Type = IngredientType.Cheese,
                    Weight = 70,
                    Price = 40
                }
                );
            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    IsDelivered = false,
                    UserId = 1,
                    PizzaIds = { 1, 6 }
                },
                new Order()
                {
                    IsDelivered = true,
                    UserId = 1,
                    PizzaIds = { 2 }
                }, new Order()
                {
                    IsDelivered = false,
                    UserId = 2,
                    PizzaIds = { 2, 4 }
                }, new Order()
                {
                    IsDelivered = false,
                    UserId = 3,
                    PizzaIds = { 3, 7 }
                }, new Order()
                {
                    IsDelivered = true,
                    UserId = 3,
                    PizzaIds = { 8 }
                }
                );
        }
    }
}
