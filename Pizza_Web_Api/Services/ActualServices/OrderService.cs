using Data.Interfaces;
using Domain_Models.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ActualServices
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepo;
        public OrderService(IRepository<Order> orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public bool CreateOrder(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public OrderModel GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> GetOrdersForUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(OrderModel order)
        {
            throw new NotImplementedException();
        }
    }
}
