using Data.DatabaseContext;
using Data.Interfaces;
using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private PizzaDbContext _context;
        public OrderRepository(PizzaDbContext context)
        {
            _context = context;
        }
        public bool Create(Order entity)
        {
            _context.Orders.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var order = _context.Orders.SingleOrDefault(o => o.Id == id);
            _context.Orders.Remove(order);
            return true;
        }

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.SingleOrDefault(o => o.Id == id);
        }

        public bool Update(Order entity)
        {
            _context.Orders.Update(entity);
            return true;
        }
    }
}
