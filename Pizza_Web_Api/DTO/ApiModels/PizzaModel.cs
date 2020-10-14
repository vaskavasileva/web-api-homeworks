using Domain_Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain_Models.Models
{
    public class PizzaModel 
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> IngredientIds { get; set; }
        
        public PizzaSize Size { get; set; }
        public int Price { get; set; }

        
    }
}
