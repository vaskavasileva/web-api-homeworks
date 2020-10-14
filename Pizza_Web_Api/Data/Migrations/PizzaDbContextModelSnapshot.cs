﻿// <auto-generated />
using System;
using Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(PizzaDbContext))]
    partial class PizzaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain_Models.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("PizzaId");

                    b.Property<int>("Price");

                    b.Property<int>("Type");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new { Id = 1, Name = "StandardDoughSmall", Price = 50, Type = 1, Weight = 50 },
                        new { Id = 2, Name = "StandardDoughMedium", Price = 80, Type = 1, Weight = 60 },
                        new { Id = 3, Name = "StandardDoughLarge", Price = 110, Type = 1, Weight = 70 },
                        new { Id = 4, Name = "StandardDoughFamily", Price = 150, Type = 1, Weight = 80 },
                        new { Id = 5, Name = "Peperoni", Price = 50, Type = 3, Weight = 40 },
                        new { Id = 6, Name = "Mushrooms", Price = 70, Type = 4, Weight = 50 },
                        new { Id = 7, Name = "Chedar", Price = 110, Type = 2, Weight = 60 },
                        new { Id = 8, Name = "MozarellaCheese", Price = 40, Type = 2, Weight = 70 }
                    );
                });

            modelBuilder.Entity("Domain_Models.Models.IngredientPizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredientId");

                    b.Property<int>("PizzaId");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("PizzaId");

                    b.ToTable("IngredientPizza");

                    b.HasData(
                        new { Id = 1, IngredientId = 1, PizzaId = 1 },
                        new { Id = 2, IngredientId = 5, PizzaId = 1 },
                        new { Id = 3, IngredientId = 6, PizzaId = 1 },
                        new { Id = 4, IngredientId = 8, PizzaId = 1 },
                        new { Id = 5, IngredientId = 2, PizzaId = 2 },
                        new { Id = 6, IngredientId = 5, PizzaId = 2 },
                        new { Id = 7, IngredientId = 6, PizzaId = 2 },
                        new { Id = 8, IngredientId = 8, PizzaId = 2 },
                        new { Id = 9, IngredientId = 3, PizzaId = 3 },
                        new { Id = 10, IngredientId = 5, PizzaId = 3 },
                        new { Id = 11, IngredientId = 6, PizzaId = 3 },
                        new { Id = 12, IngredientId = 8, PizzaId = 3 },
                        new { Id = 13, IngredientId = 4, PizzaId = 4 },
                        new { Id = 14, IngredientId = 5, PizzaId = 4 },
                        new { Id = 15, IngredientId = 6, PizzaId = 4 },
                        new { Id = 16, IngredientId = 8, PizzaId = 4 },
                        new { Id = 17, IngredientId = 1, PizzaId = 5 },
                        new { Id = 18, IngredientId = 5, PizzaId = 5 },
                        new { Id = 19, IngredientId = 6, PizzaId = 5 },
                        new { Id = 20, IngredientId = 7, PizzaId = 5 },
                        new { Id = 21, IngredientId = 8, PizzaId = 5 },
                        new { Id = 22, IngredientId = 2, PizzaId = 6 },
                        new { Id = 23, IngredientId = 5, PizzaId = 6 },
                        new { Id = 24, IngredientId = 6, PizzaId = 6 },
                        new { Id = 25, IngredientId = 7, PizzaId = 6 },
                        new { Id = 26, IngredientId = 8, PizzaId = 6 },
                        new { Id = 27, IngredientId = 3, PizzaId = 7 },
                        new { Id = 28, IngredientId = 5, PizzaId = 7 },
                        new { Id = 29, IngredientId = 6, PizzaId = 7 },
                        new { Id = 30, IngredientId = 7, PizzaId = 7 },
                        new { Id = 31, IngredientId = 8, PizzaId = 7 },
                        new { Id = 32, IngredientId = 4, PizzaId = 8 },
                        new { Id = 33, IngredientId = 5, PizzaId = 8 },
                        new { Id = 34, IngredientId = 6, PizzaId = 8 },
                        new { Id = 35, IngredientId = 7, PizzaId = 8 },
                        new { Id = 36, IngredientId = 8, PizzaId = 8 }
                    );
                });

            modelBuilder.Entity("Domain_Models.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelivered");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new { Id = 1, IsDelivered = false, UserId = 1 },
                        new { Id = 2, IsDelivered = true, UserId = 1 },
                        new { Id = 3, IsDelivered = false, UserId = 2 },
                        new { Id = 4, IsDelivered = false, UserId = 3 },
                        new { Id = 5, IsDelivered = true, UserId = 3 }
                    );
                });

            modelBuilder.Entity("Domain_Models.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("OrderId");

                    b.Property<int>("Price");

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new { Id = 1, Name = "PassionPizza", Price = 0, Size = 1 },
                        new { Id = 2, Name = "PassionPizza", Price = 0, Size = 2 },
                        new { Id = 3, Name = "PassionPizza", Price = 0, Size = 3 },
                        new { Id = 4, Name = "PassionPizza", Price = 0, Size = 4 },
                        new { Id = 5, Name = "DifferentPizza", Price = 0, Size = 1 },
                        new { Id = 6, Name = "DifferentPizza", Price = 0, Size = 2 },
                        new { Id = 7, Name = "DifferentPizza", Price = 0, Size = 3 },
                        new { Id = 8, Name = "DifferentPizza", Price = 0, Size = 4 }
                    );
                });

            modelBuilder.Entity("Domain_Models.Models.PizzaOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("PizzaId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PizzaId");

                    b.ToTable("PizzaOrder");

                    b.HasData(
                        new { Id = 1, OrderId = 1, PizzaId = 1 },
                        new { Id = 2, OrderId = 1, PizzaId = 6 },
                        new { Id = 3, OrderId = 2, PizzaId = 2 },
                        new { Id = 4, OrderId = 3, PizzaId = 2 },
                        new { Id = 5, OrderId = 3, PizzaId = 4 },
                        new { Id = 6, OrderId = 4, PizzaId = 3 },
                        new { Id = 7, OrderId = 4, PizzaId = 7 },
                        new { Id = 8, OrderId = 5, PizzaId = 8 }
                    );
                });

            modelBuilder.Entity("Domain_Models.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("Phone");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Address = "Address1", FirstName = "Vaska", LastName = "Vasileva", Password = "123vaska123", Phone = 70264353, Username = "Vaska123" },
                        new { Id = 2, Address = "Address2", FirstName = "Goce", LastName = "Kabov", Password = "456goce456", Phone = 71585969, Username = "GoceK456" },
                        new { Id = 3, Address = "Address3", FirstName = "Darko", LastName = "Panchevski", Password = "789dare789", Phone = 75742394, Username = "DareP789" }
                    );
                });

            modelBuilder.Entity("Domain_Models.Models.Ingredient", b =>
                {
                    b.HasOne("Domain_Models.Models.Pizza")
                        .WithMany("Ingredients")
                        .HasForeignKey("PizzaId");
                });

            modelBuilder.Entity("Domain_Models.Models.IngredientPizza", b =>
                {
                    b.HasOne("Domain_Models.Models.Ingredient", "Ingredient")
                        .WithMany("IngredientPizzas")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain_Models.Models.Pizza", "Pizza")
                        .WithMany("IngredientPizzas")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain_Models.Models.Order", b =>
                {
                    b.HasOne("Domain_Models.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain_Models.Models.Pizza", b =>
                {
                    b.HasOne("Domain_Models.Models.Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Domain_Models.Models.PizzaOrder", b =>
                {
                    b.HasOne("Domain_Models.Models.Order", "Order")
                        .WithMany("PizzaOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain_Models.Models.Pizza", "Pizza")
                        .WithMany("PizzaOrders")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}