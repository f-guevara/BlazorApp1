using BlazorApp1.Models;
using System.Text.Json;

namespace BlazorApp1.Services
{
    public class OrderService : IOrderService
    {
        private readonly string _filePath = "orders.json";

        public List<Order> GetAllOrders()
        {
            if (!File.Exists(_filePath))
                return new List<Order>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Order>>(json) ?? new List<Order>();
        }

        public Order GetOrderById(int orderId)
        {
            return GetAllOrders().FirstOrDefault(o => o.OrderId == orderId);
        }

        public void AddOrder(Order order)
        {
            var orders = GetAllOrders();
            order.OrderId = orders.Any() ? orders.Max(o => o.OrderId) + 1 : 1;
            order.OrderDate = DateTime.Now;
            orders.Add(order);
            SaveOrders(orders);
        }

        public void UpdateOrder(Order order)
        {
            var orders = GetAllOrders();
            var existingOrder = orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            if (existingOrder != null)
            {
                existingOrder.ClientId = order.ClientId;
                existingOrder.OrderItems = order.OrderItems;
                existingOrder.OrderDate = order.OrderDate;
                SaveOrders(orders);
            }
        }

        public void DeleteOrder(int orderId)
        {
            var orders = GetAllOrders();
            orders.RemoveAll(o => o.OrderId == orderId);
            SaveOrders(orders);
        }

        private void SaveOrders(List<Order> orders)
        {
            var json = JsonSerializer.Serialize(orders);
            File.WriteAllText(_filePath, json);
        }
    }
}
