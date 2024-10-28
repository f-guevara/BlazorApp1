using BlazorApp1.Models;
using BlazorApp1.Services;

namespace BlazorApp1
{
    public class DataSeeder
    {
        private readonly IClientService _clientService;
        private readonly IImplantService _implantService;

        public DataSeeder(IClientService clientService, IImplantService implantService)
        {
            _clientService = clientService;
            _implantService = implantService;
        }

        public void SeedData()
        {
            SeedClients();
            SeedImplants();
        }

        private void SeedClients()
        {
            var clients = _clientService.GetAllClients();
            if (clients.Count == 0)
            {
                _clientService.AddClient(new Client
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Company = "MedTech USA",
                    Address = new Address
                    {
                        AddressLine1 = "123 Main St",
                        AddressLine2 = "Suite 101",
                        City = "New York",
                        State = "NY",
                        Country = "USA",
                        CountryCode = "US",
                        PostalCode = "10001",
                        Region = "Northeast"
                    },
                    Phone = new Phone { AreaCode = "212", LocalNumber = "5551234" },
                    Email = "john.doe@example.com"
                });

                _clientService.AddClient(new Client
                {
                    Id = 2,
                    FirstName = "Maria",
                    LastName = "Garcia",
                    Company = "HealthCorp",
                    Address = new Address
                    {
                        AddressLine1 = "456 Calle Mayor",
                        City = "Madrid",
                        State = "Madrid",
                        Country = "Spain",
                        CountryCode = "ES",
                        PostalCode = "28013",
                        Region = "Central"
                    },
                    Phone = new Phone { AreaCode = "91", LocalNumber = "1234567" },
                    Email = "maria.garcia@example.com"
                });
                _clientService.AddClient(new Client
                {
                    Id = 3,
                    FirstName = "Hans",
                    LastName = "Schmidt",
                    Company = "MedEquip GmbH",
                    Address = new Address
                    {
                        AddressLine1 = "789 Berliner Strasse",
                        City = "Berlin",
                        State = "Berlin",
                        Country = "Germany",
                        CountryCode = "DE",
                        PostalCode = "10115",
                        Region = "Berlin"
                    },
                    Phone = new Phone { AreaCode = "30", LocalNumber = "9876543" },
                    Email = "hans.schmidt@example.com"
                });
                _clientService.AddClient(new Client
                {
                    Id = 4,
                    FirstName = "Akira",
                    LastName = "Tanaka",
                    Company = "Surgical Japan",
                    Address = new Address
                    {
                        AddressLine1 = "12-34 Sakura Ave",
                        City = "Tokyo",
                        State = "Tokyo",
                        Country = "Japan",
                        CountryCode = "JP",
                        PostalCode = "100-0001",
                        Region = "Kanto"
                    },
                    Phone = new Phone { AreaCode = "3", LocalNumber = "4567890" },
                    Email = "akira.tanaka@example.com"
                });
            }
        }

        private void SeedImplants()
        {
            var implants = _implantService.GetAllImplants();
            if (implants.Count == 0)
            {
                _implantService.AddImplant(new Implant { McmId = "01-504-02", Name = "MINI-MICRO PLATE Straight Shape, 2 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 6.75m });
                _implantService.AddImplant(new Implant { McmId = "01-504-04", Name = "MINI-MICRO PLATE Straight Shape, 4 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 8.75m });
                _implantService.AddImplant(new Implant { McmId = "01-504-06", Name = "MINI-MICRO PLATE Straight Shape, 6 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 10.65m });

                _implantService.AddImplant(new Implant { McmId = "01-504-08", Name = "MINI-MICRO PLATE Straight Shape, 8 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 12.50m });

                _implantService.AddImplant(new Implant { McmId = "01-504-12", Name = "MINI-MICRO PLATE \"Straight\" Shape, 12 Holes", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 14.70m });

                _implantService.AddImplant(new Implant { McmId = "01-501-03", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 3.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 5.50m });

                _implantService.AddImplant(new Implant { McmId = "01-501-04", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 4.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 6.50m });

                _implantService.AddImplant(new Implant { McmId = "01-501-05", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 5.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 7.50m });

                _implantService.AddImplant(new Implant { McmId = "01-501-06", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 6.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 8.25m });

                _implantService.AddImplant(new Implant { McmId = "01-501-07", Name = "CROSS HEAD, Mini-Microplating Screw 1.0 x 7.0mm SelfCutting", System = ImplantSystem.MiniMicroPlatingSystem_1_0mm_0_55mm, Type = ImplantType.Other, Price = 9.80m });

            }
        }
    }
}
