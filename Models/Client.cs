using System.Net;

namespace BlazorApp1.Models
{
    public class Client
    {
        public int Id { get; set; } = 0;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public Address Address { get; set; } = new Address();
        public Phone Phone { get; set; } = new Phone();
        public string Email { get; set; } = string.Empty;
    }
}