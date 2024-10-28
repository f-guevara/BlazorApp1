using BlazorApp1.Models;
using System.Text.Json;

namespace BlazorApp1.Services
{
    public class OrderService : IOrderService
    {
        private readonly string _filePath = "orders.json";
        private readonly IImplantService _implantService;

        // Constructor with dependency injection for IImplantService
        public OrderService(IImplantService implantService)
        {
            _implantService = implantService ?? throw new ArgumentNullException(nameof(implantService));
        }
        public List<Order> GetAllOrders()
        {
            if (!File.Exists(_filePath))
                return new List<Order>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Order>>(json) ?? new List<Order>();
        }

        public decimal GetOrderTotal(Order order)
        {
            var implants = _implantService.GetAllImplants();  // Retrieve implant list from service

            return order.OrderItems.Sum(item =>
            {
                var implant = implants.FirstOrDefault(i => i.Id == item.ImplantId);
                return implant != null ? implant.Price * item.Quantity : 0;
            });
        }

        public Order GetOrderById(int orderId)
        {
            return GetAllOrders().FirstOrDefault(o => o.Id == orderId);
        }

        public void AddOrder(Order order)
        {
            var orders = GetAllOrders();
            order.Id = orders.Any() ? orders.Max(o => o.Id) + 1 : 1;
            order.OrderDate = DateTime.Now;
            orders.Add(order);
            SaveOrders(orders);
        }

        public void UpdateOrder(Order order)
        {
            var orders = GetAllOrders();
            var existingOrder = orders.FirstOrDefault(o => o.Id == order.Id);
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
            orders.RemoveAll(o => o.Id == orderId);
            SaveOrders(orders);
        }

        private void SaveOrders(List<Order> orders)
        {
            var json = JsonSerializer.Serialize(orders);
            File.WriteAllText(_filePath, json);
        }
    }
}
