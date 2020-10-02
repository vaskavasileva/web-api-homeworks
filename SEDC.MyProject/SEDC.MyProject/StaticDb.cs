using SEDC.MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.MyProject
{
    public static class StaticDb
    {
        public static List<User> AllUsers = new List<User>()
        {
            new User()
            {
                Id = 1,
                FirstName = "Vaska",
                LastName = "Vasileva"
            },
            new User()
            {
                Id = 2,
                FirstName = "Goce",
                LastName = "Kabov"
            },
            new User()
            {
                Id = 3,
                FirstName = "Darko",
                LastName = "Panchevski"
            },
            new User()
            {
                Id = 4,
                FirstName = "Matej",
                LastName = "Jovanov"
            },
            new User()
            {
                Id = 5,
                FirstName = "Tea",
                LastName = "Stojkovska"
            },
            new User()
            {
                Id = 6,
                FirstName = "Jovana",
                LastName = "Jovanovska"
            },
        };
    }
}
