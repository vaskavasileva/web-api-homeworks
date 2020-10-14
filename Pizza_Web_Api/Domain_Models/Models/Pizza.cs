using Domain_Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain_Models.Models
{
    public class Pizza : BaseEntity
    {
        
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public List<IngredientPizza> IngredientPizzas { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public PizzaSize Size { get; set; }
        [Required]
        public int Price { get; set; }
        public List<PizzaOrder> PizzaOrders { get; set; }

        private int CalculatePrice(List<Ingredient> ingredients)
        {
            var result = 0;
            foreach (var item in ingredients)
            {
                result += item.Price;
            }
            return result;
        }
    }
}
