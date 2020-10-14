using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappings
{
    public static class IngredientMapper
    {
        public static Ingredient IngredientModelToIngredient(IngredientModel model)
        {
            return new Ingredient()
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                Type = model.Type,
                Weight = model.Weight
            };
        }

        public static IngredientModel IngredientToIngredientModel(Ingredient ing)
        {
            return new IngredientModel()
            {
                Id = ing.Id,
                Name = ing.Name,
                Price = ing.Price,
                Type = ing.Type,
                Weight = ing.Weight
            };
        }

        public static List<Ingredient> IngredientModelsToIngredients(List<IngredientModel> models)
        {
            return models.Select(m => IngredientModelToIngredient(m)).ToList();
        }

        public static List<IngredientModel> IngredientsToIngredientModels(List<Ingredient> ings)
        {
            return ings.Select(i => IngredientToIngredientModel(i)).ToList();
        }
    }
}
