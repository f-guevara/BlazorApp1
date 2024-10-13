using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IClientService
    {
        List<Client> GetAllClients();
        void AddClient(Client client);
        void UpdateClient(Client client);
        void DeleteClient(int clientId);
    }
}
