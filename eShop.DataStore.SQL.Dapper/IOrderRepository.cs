using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.DataStore.SQL.Dapper
{
    public interface IOrderRepository
    {
        int CreateOrder(Order order);
        IEnumerable<OrderLineItem> GetLineItemsByOrderId(int orderId);
        Order GetOrder(int id);
        Order GetOrderByUniqueId(string uniqueId);
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOutstandingOrders();
        IEnumerable<Order> GetProcessedOrders();
        void UpdateOrder(Order order);
    }
}