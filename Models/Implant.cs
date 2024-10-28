

namespace BlazorApp1.Models
{
    public class Implant
    {
        public int Id { get; set; } = 0;
        public string McmId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ImplantSystem System { get; set; } = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm;
        public ImplantType Type { get; set; } = ImplantType.Instrument;
        public decimal Price { get; set; } = 0.00m;
    }
}
