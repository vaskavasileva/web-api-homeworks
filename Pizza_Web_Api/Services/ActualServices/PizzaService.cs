using Data.Interfaces;
using Domain_Models.Enums;
using Domain_Models.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ActualServices
{
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepo;
        public PizzaService(IRepository<Pizza> pizzaRepo)
        {
            _pizzaRepo = pizzaRepo;
        }
        public bool CreatePizza(PizzaModel pizza)
        {
            throw new NotImplementedException();
        }

        public bool DeletePizza(int id)
        {
            throw new NotImplementedException();
        }

        public List<PizzaModel> GetAllPizzas()
        {
            throw new NotImplementedException();
        }

        public PizzaModel GetPizzaById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PizzaModel> GetPizzasBySize(PizzaSize size)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePizza(PizzaModel pizza)
        {
            throw new NotImplementedException();
        }
    }
}
