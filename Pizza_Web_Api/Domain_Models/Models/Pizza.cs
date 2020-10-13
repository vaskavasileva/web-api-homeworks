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
        public Pizza()
        {
            Price = this.CalculatePrice(this.Ingredients);
        }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public List<int> IngredientIds { get; set; }
        [ForeignKey("IngredientIds")]
        public virtual List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public PizzaSize Size { get; set; }
        [Required]
        public int Price { get; set; }

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
