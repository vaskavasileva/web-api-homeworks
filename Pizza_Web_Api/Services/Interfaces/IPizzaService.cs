using Domain_Models.Enums;
using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaModel> GetAllPizzas();
        PizzaModel GetPizzaById(int id);
        bool CreatePizza(PizzaModel pizza);
        bool DeletePizza(int id);
        bool UpdatePizza(PizzaModel pizza);
        List<PizzaModel> GetPizzasBySize(PizzaSize size);
    }
}
