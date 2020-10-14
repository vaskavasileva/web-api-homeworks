using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappings
{
    public static class PizzaMapper
    {
        public static Pizza PizzaModelToPizza(PizzaModel model)
        {
            return new Pizza()
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                Size = model.Size
            };
        }

        public static PizzaModel PizzaToPizzaModel(Pizza pizza)
        {
            return new PizzaModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                Size = pizza.Size
            };
        }

        public static List<Pizza> PizzaModelsToPizzas(List<PizzaModel> models)
        {
            return models.Select(m => PizzaModelToPizza(m)).ToList();
        }

        public static List<PizzaModel> PizzasToPizzaModels(List<Pizza> pizzas)
        {
            return pizzas.Select(p => PizzaToPizzaModel(p)).ToList();
        }
    }
}
