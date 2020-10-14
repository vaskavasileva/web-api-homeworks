using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain_Models.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int Phone { get; set; }
        
        public string Address { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        public List<int> OrderIds { get; set; }
        
    }
}
