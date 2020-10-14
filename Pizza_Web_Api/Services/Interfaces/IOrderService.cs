using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderModel> GetOrdersForUser(UserModel user);
        List<OrderModel> GetAllOrders();
        OrderModel GetOrderById(int id);
        bool CreateOrder(OrderModel order);
        bool UpdateOrder(OrderModel order);
        bool DeleteOrder(int id);
    }
}
