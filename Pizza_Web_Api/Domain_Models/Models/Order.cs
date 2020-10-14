using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain_Models.Models
{
    public class Order : BaseEntity
    {
        public virtual List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; } 
        public bool IsDelivered { get; set; }
        public List<PizzaOrder> PizzaOrders { get; set; }
    }
}
