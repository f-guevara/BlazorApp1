namespace BlazorApp1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public DateTime OrderDate { get; set; }
    }
}