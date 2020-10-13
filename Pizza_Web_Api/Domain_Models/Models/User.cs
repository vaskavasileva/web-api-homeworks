using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain_Models.Models
{
    public class User : BaseEntity
    {
        [MinLength(2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public int Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [MinLength(8)]
        public string Username { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public List<int> OrderIds { get; set; }
        [ForeignKey("OrderIds")]
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
