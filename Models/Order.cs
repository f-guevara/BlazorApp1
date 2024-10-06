namespace BlazorApp1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ImplantId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        public Client Client { get; set; }
        public Implant Implant { get; set; }
    }

}
