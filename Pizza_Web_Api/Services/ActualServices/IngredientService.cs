using Data.Interfaces;
using Domain_Models.Enums;
using Domain_Models.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ActualServices
{
    public class IngredientService : IIngredientService
    {
        private IRepository<Ingredient> _ingredientRepo;
        public IngredientService(IRepository<Ingredient> ingredientRepo)
        {
            _ingredientRepo = ingredientRepo;
        }
        public List<IngredientModel> GetAllIngredients()
        {
            throw new NotImplementedException();
        }

        public IngredientModel GetIngredientById(int id)
        {
            throw new NotImplementedException();
        }

        public List<IngredientModel> GetIngredientsByType(IngredientType type)
        {
            throw new NotImplementedException();
        }
    }
}
