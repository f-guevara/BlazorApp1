using System.Xml.Serialization;
using System.IO;

namespace BlazorApp1
{


    public class FileDataHandler<T> : IDataHandler<T> where T : class
    {
        private readonly string _filePath;

        public FileDataHandler(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<List<T>> LoadAsync()
        {
            if (!File.Exists(_filePath))
            {
                return new List<T>();
            }

            var xmlData = await File.ReadAllTextAsync(_filePath);
            if (string.IsNullOrWhiteSpace(xmlData))
            {
                return new List<T>();
            }

            // Deserialize XML to List<T> using XmlHelper
            return XmlHelper.Deserialize<List<T>>(xmlData);
        }

        public async Task SaveAsync(T data)
        {
            var currentData = await LoadAsync();
            currentData.Add(data);

            var xmlData = XmlHelper.Serialize(currentData);
            await File.WriteAllTextAsync(_filePath, xmlData);
        }
    }


}
