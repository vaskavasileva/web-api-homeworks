using Data.Interfaces;
using Domain_Models.Models;
using Mappings;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _orderRepo.Create(OrderMapper.OrderModelToOrder(order));
            
        }

        public bool DeleteOrder(int id)
        {
            return _orderRepo.Delete(id);
        }

        public List<OrderModel> GetAllOrders()
        {
            return OrderMapper.OrdersToOrderModels(_orderRepo.GetAll());
        }

        public OrderModel GetOrderById(int id)
        {
            return OrderMapper.OrderToOrderModel(_orderRepo.GetById(id));
        }

        public List<OrderModel> GetOrdersForUser(UserModel user)
        {
            return OrderMapper.OrdersToOrderModels(_orderRepo.GetAll().Where(o => o.UserId == user.Id).ToList());
        }

        public bool UpdateOrder(OrderModel order)
        {
            return _orderRepo.Update(OrderMapper.OrderModelToOrder(order));
        }
    }
}
