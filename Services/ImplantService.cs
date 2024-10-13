using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class ImplantService : IImplantService
    {
        private readonly List<Implant> implants = new();

        public List<Implant> GetAllImplants() => implants;

        public void AddImplant(Implant implant)
        {
            implant.ImplantId = implants.Count == 0 ? 1 : implants.Max(i => i.ImplantId) + 1;
            implants.Add(implant);
        }

        public void UpdateImplant(Implant implant)
        {
            var existingImplant = implants.FirstOrDefault(i => i.ImplantId == implant.ImplantId);
            if (existingImplant != null)
            {
                existingImplant.McmId = implant.McmId;
                existingImplant.Name = implant.Name;
                existingImplant.System = implant.System;
                existingImplant.Type = implant.Type;
                existingImplant.Price = implant.Price;
            }
        }

        public void DeleteImplant(int implantId)
        {
            var implant = implants.FirstOrDefault(i => i.ImplantId == implantId);
            if (implant != null)
            {
                implants.Remove(implant);
            }
        }

        public ImplantService()
        {
            implants.Add(new Implant { ImplantId = 1, McmId = "01-504-02", Name = "MINI-MICRO PLATE Straight Shape, 2 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 6.75m });
            implants.Add(new Implant { ImplantId = 2, McmId = "01-504-04", Name = "MINI-MICRO PLATE Straight Shape, 4 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 8.75m });
            implants.Add(new Implant { ImplantId = 3, McmId = "01-504-06", Name = "MINI-MICRO PLATE Straight Shape, 6 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 10.65m });
            implants.Add(new Implant { ImplantId = 4, McmId = "01-504-08", Name = "MINI-MICRO PLATE Straight Shape, 8 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 12.50m });
            implants.Add(new Implant { ImplantId = 5, McmId = "01-504-12", Name = "MINI-MICRO PLATE \"Straight\" Shape, 12 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 14.70m });
            implants.Add(new Implant { ImplantId = 6, McmId = "01-501-03", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 3.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 5.50m });
            implants.Add(new Implant { ImplantId = 7, McmId = "01-501-04", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 4.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 6.50m });
            implants.Add(new Implant { ImplantId = 8, McmId = "01-501-05", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 5.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 7.50m });
            implants.Add(new Implant { ImplantId = 9, McmId = "01-501-06", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 6.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 8.25m });
            implants.Add(new Implant { ImplantId = 10, McmId = "01-501-07", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 7.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 9.80m });
        }
    }

    
    
}
