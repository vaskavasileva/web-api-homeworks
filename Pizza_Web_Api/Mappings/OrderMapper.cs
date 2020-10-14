using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;

namespace Mappings
{
    public static class OrderMapper
    {
        public static Order OrderModelToOrder(OrderModel model)
        {
            return new Order()
            {
                Id = model.Id,
                IsDelivered = model.IsDelivered,
                UserId = model.UserId
            };
        }

        public static OrderModel OrderToOrderModel(Order order)
        {
            return new OrderModel()
            {
                Id = order.Id,
                IsDelivered = order.IsDelivered,
                UserId = order.UserId
            };
        }

        public static List<Order> OrderModelsToOrders(List<OrderModel> models)
        {
            return models.Select(m => OrderModelToOrder(m)).ToList();
        }

        public static List<OrderModel> OrdersToOrderModels(List<Order> orders)
        {
            return orders.Select(o => OrderToOrderModel(o)).ToList();
        }
    }
}
