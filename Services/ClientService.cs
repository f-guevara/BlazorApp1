using BlazorApp1.Models;
using BlazorApp1.Services;
using System.Text.Json;

public class ClientService : IClientService
{
    private readonly string _filePath = "clients.json";

    public List<Client> GetAllClients()
    {
        if (!File.Exists(_filePath))
            return new List<Client>();

        var json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<Client>>(json) ?? new List<Client>();
    }

    public void AddClient(Client client)
    {
        var clients = GetAllClients();
        client.Id = clients.Count == 0 ? 1 : clients.Max(c => c.Id) + 1;
        clients.Add(client);
        SaveClients(clients);
    }

    public void UpdateClient(Client client)
    {
        var clients = GetAllClients();
        var existingClient = clients.FirstOrDefault(c => c.Id == client.Id);
        if (existingClient != null)
        {
            existingClient.FirstName = client.FirstName;
            existingClient.MiddleName = client.MiddleName;
            existingClient.LastName = client.LastName;
            existingClient.Company = client.Company;
            existingClient.Address = client.Address;
            existingClient.Phone = client.Phone;
            existingClient.Email = client.Email;
            SaveClients(clients);
        }
    }

    public void DeleteClient(int clientId)
    {
        var clients = GetAllClients();
        clients.RemoveAll(c => c.Id == clientId);
        SaveClients(clients);
    }

    private void SaveClients(List<Client> clients)
    {
        var json = JsonSerializer.Serialize(clients);
        File.WriteAllText(_filePath, json);
    }
}
