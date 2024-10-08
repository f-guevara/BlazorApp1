using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public static class TestData
    {
        public static List<Implant> GetImplants()
        {
            return new List<Implant>
            {
                new Implant { Id = 1, Name = "MINI-MICRO PLATE Straight Shape, 2 Holes,", Type = "plate", Price = 6.75M },
                new Implant { Id = 2, Name = "MINI-MICRO PLATE Straight Shape, 4 Holes,", Type = "plate", Price = 8.75M },
                new Implant { Id = 3, Name = "MINI-MICRO PLATE Straight Shape, 6 Holes,", Type = "plate", Price = 10.65M },
                new Implant { Id = 4, Name = "MINI-MICRO PLATE Straight Shape, 8 Holes,", Type = "plate", Price = 12.50M },
                new Implant { Id = 5, Name = "MINI-MICRO PLATE \"Straight\" Shape,12", Type = "plate", Price = 14.70M },
                new Implant { Id = 6, Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 3.0mm SelfCutting,", Type = "screw", Price = 5.50M },
                new Implant { Id = 7, Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 4.0mm SelfCutting,", Type = "screw", Price = 6.50M },
                new Implant { Id = 8, Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 5.0mm SelfCutting,", Type = "screw", Price = 7.50M },
                new Implant { Id = 9, Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 6.0mm SelfCutting,", Type = "screw", Price = 8.25M },
                new Implant { Id = 10, Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 7.0mm SelfCutting,", Type = "screw", Price = 9.80M }
            };
        }
    }
}
