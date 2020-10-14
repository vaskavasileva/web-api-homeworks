using Data.DatabaseContext;
using Data.Interfaces;
using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class IngredientRepository : IRepository<Ingredient>
    {
        private PizzaDbContext _context;
        public IngredientRepository(PizzaDbContext context)
        {
            _context = context;
        }
        public bool Create(Ingredient entity)
        {
            _context.Ingredients.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var ingredient = _context.Ingredients.SingleOrDefault(i => i.Id == id);
            _context.Ingredients.Remove(ingredient);
            return true;
        }

        public List<Ingredient> GetAll()
        {
            return _context.Ingredients.ToList();
        }

        public Ingredient GetById(int id)
        {
            return _context.Ingredients.SingleOrDefault(i => i.Id == id);
        }

        public bool Update(Ingredient entity)
        {
            _context.Ingredients.Update(entity);
            return true;
        }
    }
}
