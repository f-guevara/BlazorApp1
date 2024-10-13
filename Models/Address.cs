namespace BlazorApp1.Models
{
    public class Address
    {
        public string AddressLine1 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{AddressLine1}, {(string.IsNullOrEmpty(AddressLine2) ? "" : AddressLine2 + ", ")}{City}, {Region}, {State}, {Country}, {PostalCode}";
        }
    }
}
