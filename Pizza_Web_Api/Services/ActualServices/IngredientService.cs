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
    public class IngredientService : IIngredientService
    {
        private IRepository<Ingredient> _ingredientRepo;
        public IngredientService(IRepository<Ingredient> ingredientRepo)
        {
            _ingredientRepo = ingredientRepo;
        }
        public List<IngredientModel> GetAllIngredients()
        {
            return IngredientMapper.IngredientsToIngredientModels(_ingredientRepo.GetAll());
        }

        public IngredientModel GetIngredientById(int id)
        {
            return IngredientMapper.IngredientToIngredientModel(_ingredientRepo.GetById(id));
        }

        public List<IngredientModel> GetIngredientsByType(IngredientType type)
        {
            return IngredientMapper.IngredientsToIngredientModels(_ingredientRepo.GetAll().Where(i => i.Type == type).ToList());
        }
    }
}
