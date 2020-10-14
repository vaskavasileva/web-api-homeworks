using Domain_Models.Enums;
using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IIngredientService
    {
        List<IngredientModel> GetAllIngredients();
        List<IngredientModel> GetIngredientsByType(IngredientType type);
        IngredientModel GetIngredientById(int id);
    }
}
