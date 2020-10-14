using Domain_Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain_Models.Models
{
    public class Ingredient : BaseEntity
    {
        [MinLength(3)]
        [Required]
        public string Name { get; set; }
        public IngredientType Type { get; set; }
        public int Weight { get; set; }
        [Required]
        public int Price { get; set; }
        public List<IngredientPizza> IngredientPizzas { get; set; }
    }
}
