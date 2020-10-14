using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain_Models.Models
{
    public class IngredientPizza : BaseEntity
    {
        public int IngredientId { get; set; }
        [ForeignKey("IngredientId")]
        public Ingredient Ingredient { get; set; }
        public int PizzaId { get; set; }
        [ForeignKey("PizzaId")]
        public Pizza Pizza { get; set; }
    }
}
