using System.Xml.Serialization;
using System.IO;

namespace BlazorApp1
{
    

    public class FileDataHandler<T> : IDataHandler<T>
    {
        private readonly string filePath;

        public FileDataHandler(string path)
        {
            filePath = path;
        }

        public async Task<List<T>> LoadAsync()
        {
            if (!File.Exists(filePath))
            {
                return new List<T>(); // Return empty list if file doesn't exist
            }

            using var stream = new FileStream(filePath, FileMode.Open);
            var serializer = new XmlSerializer(typeof(List<T>));
            return (List<T>)serializer.Deserialize(stream);
        }

        public async Task SaveAsync(T data)
        {
            List<T> existingData = await LoadAsync(); // Load current data
            existingData.Add(data); // Add the new data

            using var stream = new FileStream(filePath, FileMode.Create);
            var serializer = new XmlSerializer(typeof(List<T>));
            serializer.Serialize(stream, existingData);
        }
    }

}
