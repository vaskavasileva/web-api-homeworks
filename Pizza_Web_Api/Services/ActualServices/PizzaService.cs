using Data.Interfaces;
using Domain_Models.Enums;
using Domain_Models.Models;
using Mappings;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _pizzaRepo.Create(PizzaMapper.PizzaModelToPizza(pizza));
        }

        public bool DeletePizza(int id)
        {
            return _pizzaRepo.Delete(id);
        }

        public List<PizzaModel> GetAllPizzas()
        {
            return PizzaMapper.PizzasToPizzaModels(_pizzaRepo.GetAll());
        }

        public PizzaModel GetPizzaById(int id)
        {
            return PizzaMapper.PizzaToPizzaModel(_pizzaRepo.GetById(id));
        }

        public List<PizzaModel> GetPizzasBySize(PizzaSize size)
        {
            return PizzaMapper.PizzasToPizzaModels(_pizzaRepo.GetAll().Where(p => p.Size == size).ToList());
        }

        public bool UpdatePizza(PizzaModel pizza)
        {
            return _pizzaRepo.Update(PizzaMapper.PizzaModelToPizza(pizza));
        }
    }
}
