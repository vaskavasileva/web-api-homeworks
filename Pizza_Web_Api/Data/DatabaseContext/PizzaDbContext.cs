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
                    Id = 1,
                    FirstName = "Vaska",
                    LastName = "Vasileva",
                    Address = "Address1",
                    Phone = 070264353,
                    Username = "Vaska123",
                    Password = "123vaska123"
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Goce",
                    LastName = "Kabov",
                    Address = "Address2",
                    Phone = 071585969,
                    Username = "GoceK456",
                    Password = "456goce456"
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Darko",
                    LastName = "Panchevski",
                    Address = "Address3",
                    Phone = 075742394,
                    Username = "DareP789",
                    Password = "789dare789"
                }
                );

            modelBuilder.Entity<Pizza>().HasData(
                new Pizza()
                {
                    Id = 1,
                    Name = "PassionPizza",
                    Size = PizzaSize.Small
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "PassionPizza",
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "PassionPizza",
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 4,
                    Name = "PassionPizza",
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 5,
                    Name = "DifferentPizza",
                    Size = PizzaSize.Small
                },
                new Pizza()
                {
                    Id = 6,
                    Name = "DifferentPizza",
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 7,
                    Name = "DifferentPizza",
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 8,
                    Name = "DifferentPizza",
                    Size = PizzaSize.Family
                }
                );
            modelBuilder.Entity<IngredientPizza>().HasData(
                new IngredientPizza()
                {
                    Id = 1, 
                    PizzaId = 1,
                    IngredientId = 1
                },
                new IngredientPizza()
                {
                    Id = 2,
                    PizzaId = 1,
                    IngredientId = 5
                },
                new IngredientPizza()
                {
                    Id = 3,
                    PizzaId = 1,
                    IngredientId = 6
                },
                new IngredientPizza()
                {
                    Id = 4,
                    PizzaId = 1,
                    IngredientId = 8
                },
                new IngredientPizza()
                {
                    Id = 5,
                    PizzaId = 2,
                    IngredientId = 2
                },
                new IngredientPizza()
                {
                    Id = 6,
                    PizzaId = 2,
                    IngredientId = 5
                },
                new IngredientPizza()
                {
                    Id = 7,
                    PizzaId = 2,
                    IngredientId = 6
                },
                new IngredientPizza()
                {
                    Id = 8,
                    PizzaId = 2,
                    IngredientId = 8
                },
                new IngredientPizza()
                {
                    Id = 9,
                    PizzaId = 3,
                    IngredientId = 3
                },
                new IngredientPizza()
                {
                    Id = 10,
                    PizzaId = 3,
                    IngredientId = 5
                },
                new IngredientPizza()
                {
                    Id = 11,
                    PizzaId = 3,
                    IngredientId = 6
                },
                new IngredientPizza()
                {
                    Id = 12,
                    PizzaId = 3,
                    IngredientId = 8
                },
                new IngredientPizza()
                {
                    Id = 13,
                    PizzaId = 4,
                    IngredientId = 4
                },
                new IngredientPizza()
                {
                    Id = 14,
                    PizzaId = 4,
                    IngredientId = 5
                },
                new IngredientPizza()
                {
                    Id = 15,
                    PizzaId = 4,
                    IngredientId = 6
                },
                new IngredientPizza()
                {
                    Id = 16,
                    PizzaId = 4,
                    IngredientId = 8
                },
                new IngredientPizza()
                {
                    Id = 17,
                    PizzaId = 5,
                    IngredientId = 1
                },
                new IngredientPizza()
                {
                    Id = 18,
                    PizzaId = 5,
                    IngredientId = 5
                },
                new IngredientPizza()
                {
                    Id = 19,
                    PizzaId = 5,
                    IngredientId = 6
                },
                new IngredientPizza()
                {
                    Id = 20,
                    PizzaId = 5,
                    IngredientId = 7
                },
                new IngredientPizza()
                {
                    Id = 21,
                    PizzaId = 5,
                    IngredientId = 8
                },
                new IngredientPizza()
                {
                    Id = 22,
                    PizzaId = 6,
                    IngredientId = 2
                },
                new IngredientPizza()
                {
                    Id = 23,
                    PizzaId = 6,
                    IngredientId = 5
                },
                new IngredientPizza()
                {
                    Id = 24,
                    PizzaId = 6,
                    IngredientId = 6
                },
                new IngredientPizza()
                {
                    Id = 25,
                    PizzaId = 6,
                    IngredientId = 7
                },
                new IngredientPizza()
                {
                    Id = 26,
                    PizzaId = 6,
                    IngredientId = 8
                },
                new IngredientPizza()
                {
                    Id = 27,
                    PizzaId = 7,
                    IngredientId = 3
                },
                new IngredientPizza()
                {
                    Id = 28,
                    PizzaId = 7,
                    IngredientId = 5
                },
                new IngredientPizza()
                {
                    Id = 29,
                    PizzaId = 7,
                    IngredientId = 6
                },
                new IngredientPizza()
                {
                    Id = 30,
                    PizzaId = 7,
                    IngredientId = 7
                },
                new IngredientPizza()
                {
                    Id = 31,
                    PizzaId = 7,
                    IngredientId = 8
                },
                new IngredientPizza()
                {
                    Id = 32,
                    PizzaId = 8,
                    IngredientId = 4
                },
                new IngredientPizza()
                {
                    Id = 33,
                    PizzaId = 8,
                    IngredientId = 5
                },
                new IngredientPizza()
                {
                    Id = 34,
                    PizzaId = 8,
                    IngredientId = 6
                },
                new IngredientPizza()
                {
                    Id = 35,
                    PizzaId = 8,
                    IngredientId = 7
                },
                new IngredientPizza()
                {
                    Id = 36,
                    PizzaId = 8,
                    IngredientId = 8
                }
                );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    Id = 1,
                    Name = "StandardDoughSmall",
                    Type = IngredientType.Dough,
                    Weight = 50,
                    Price = 50
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "StandardDoughMedium",
                    Type = IngredientType.Dough,
                    Weight = 60,
                    Price = 80
                },
                new Ingredient()
                {
                    Id = 3,
                    Name = "StandardDoughLarge",
                    Type = IngredientType.Dough,
                    Weight = 70,
                    Price = 110
                },
                new Ingredient()
                {
                    Id = 4,
                    Name = "StandardDoughFamily",
                    Type = IngredientType.Dough,
                    Weight = 80,
                    Price = 150
                },
                new Ingredient()
                {
                    Id = 5,
                    Name = "Peperoni",
                    Type = IngredientType.Meat,
                    Weight = 40,
                    Price = 50
                },
                new Ingredient()
                {
                    Id = 6,
                    Name = "Mushrooms",
                    Type = IngredientType.Other,
                    Weight = 50,
                    Price = 70
                },
                new Ingredient()
                {
                    Id = 7,
                    Name = "Chedar",
                    Type = IngredientType.Cheese,
                    Weight = 60,
                    Price = 110
                },
                new Ingredient()
                {
                    Id = 8,
                    Name = "MozarellaCheese",
                    Type = IngredientType.Cheese,
                    Weight = 70,
                    Price = 40
                }
                );
            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    Id = 1,
                    IsDelivered = false,
                    UserId = 1
                },
                new Order()
                {
                    Id = 2,
                    IsDelivered = true,
                    UserId = 1
                },
                new Order()
                {
                    Id = 3,
                    IsDelivered = false,
                    UserId = 2
                },
                new Order()
                {
                    Id = 4,
                    IsDelivered = false,
                    UserId = 3
                }, 
                new Order()
                {
                    Id = 5,
                    IsDelivered = true,
                    UserId = 3
                }
                );
            modelBuilder.Entity<PizzaOrder>().HasData(
                new PizzaOrder()
                {
                    Id = 1,
                    OrderId = 1,
                    PizzaId = 1 
                },
                new PizzaOrder()
                {
                    Id = 2,
                    OrderId = 1,
                    PizzaId = 6
                },
                new PizzaOrder()
                {
                    Id = 3,
                    OrderId = 2,
                    PizzaId = 2
                },
                new PizzaOrder()
                {
                    Id = 4,
                    OrderId = 3,
                    PizzaId = 2
                },
                new PizzaOrder()
                {
                    Id = 5,
                    OrderId = 3,
                    PizzaId = 4
                },
                new PizzaOrder()
                {
                    Id = 6,
                    OrderId = 4,
                    PizzaId = 3
                },
                new PizzaOrder()
                {
                    Id = 7,
                    OrderId = 4,
                    PizzaId = 7
                },
                new PizzaOrder()
                {
                    Id = 8,
                    OrderId = 5,
                    PizzaId = 8
                }
                );
        }
    }
}
