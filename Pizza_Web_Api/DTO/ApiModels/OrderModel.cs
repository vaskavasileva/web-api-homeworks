using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain_Models.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public List<int> PizzaIds { get; set; }
        public int UserId { get; set; }
        public bool IsDelivered { get; set; }
    }
}
