using System.Text.Json;

namespace BlazorApp1.Services
{
    public interface IDataAccess
    {
        Task<List<T>> LoadDataAsync<T>(string fileName);
        Task SaveDataAsync<T>(string fileName, List<T> data);
    }

    
}
