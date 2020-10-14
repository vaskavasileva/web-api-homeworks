using Data.DatabaseContext;
using Data.Interfaces;
using Data.Repositories;
using Domain_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services,
            string connectionString)
        {
            services.AddDbContext<PizzaDbContext>(x => x.UseSqlServer(connectionString));
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Pizza>, PizzaRepository>();
            services.AddTransient<IRepository<Ingredient>, IngredientRepository>();
            return services;
        }
    }
}
