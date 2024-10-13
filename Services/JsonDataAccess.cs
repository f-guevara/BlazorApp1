using System.Text.Json;

namespace BlazorApp1.Services
{
    public class JsonDataAccess : IDataAccess
    {
        private readonly string _dataDirectory;

        public JsonDataAccess(string dataDirectory)
        {
            _dataDirectory = dataDirectory;
        }

        public async Task<List<T>> LoadDataAsync<T>(string fileName)
        {
            var filePath = Path.Combine(_dataDirectory, fileName);
            if (!File.Exists(filePath))
                return new List<T>();

            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<T>>(json);
        }

        public async Task SaveDataAsync<T>(string fileName, List<T> data)
        {
            var filePath = Path.Combine(_dataDirectory, fileName);
            var json = JsonSerializer.Serialize(data);
            await File.WriteAllTextAsync(filePath, json);
        }
    }
}
