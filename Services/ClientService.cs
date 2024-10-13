using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class ClientService : IClientService
    {
        private readonly List<Client> clients = new();

        public List<Client> GetAllClients() => clients;

        public void AddClient(Client client)
        {
            client.ClientId = clients.Count == 0 ? 1 : clients.Max(c => c.ClientId) + 1;
            clients.Add(client);
        }

        public void UpdateClient(Client client)
        {
            var existingClient = clients.FirstOrDefault(c => c.ClientId == client.ClientId);
            if (existingClient != null)
            {
                existingClient.FirstName = client.FirstName;
                existingClient.MiddleName = client.MiddleName;
                existingClient.LastName = client.LastName;
                existingClient.Company = client.Company;
                existingClient.Address = client.Address;
                existingClient.Phone = client.Phone;
                existingClient.Email = client.Email;
            }
        }

        public void DeleteClient(int clientId)
        {
            var client = clients.FirstOrDefault(c => c.ClientId == clientId);
            if (client != null)
            {
                clients.Remove(client);
            }
        }
        public ClientService()
        {
            clients.Add(new Client
            {
                ClientId = 1,
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
            clients.Add(new Client
            {
                ClientId = 2,
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
            clients.Add(new Client
            {
                ClientId = 3,
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
            clients.Add(new Client
            {
                ClientId = 4,
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
    }
