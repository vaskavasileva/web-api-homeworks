using Data.DatabaseContext;
using Data.Interfaces;
using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private PizzaDbContext _context;
        public PizzaRepository(PizzaDbContext context)
        {
            _context = context;
        }
        public bool Create(Pizza entity)
        {
            _context.Pizzas.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var pizza = _context.Pizzas.SingleOrDefault(p => p.Id == id);
            _context.Pizzas.Remove(pizza);
            return true;
        }

        public List<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();
        }

        public Pizza GetById(int id)
        {
            return _context.Pizzas.SingleOrDefault(p => p.Id == id);
        }

        public bool Update(Pizza entity)
        {
            _context.Pizzas.Update(entity);
            return true;
        }
    }
}
