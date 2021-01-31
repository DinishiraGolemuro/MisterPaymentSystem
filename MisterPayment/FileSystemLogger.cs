using System.IO;
using System.Threading.Tasks;

namespace MisterPayment
{
    public class FileSystemLogger
    {
        private string _filePath;

        public FileSystemLogger(string filePath)
        {
            _filePath = filePath;
        }

        public async Task Log(string message)
        {
            var fileStream = new FileStream(_filePath, FileMode.OpenOrCreate);
            var streamWriter = new StreamWriter(fileStream);

            await streamWriter.WriteLineAsync(message);
        }
    }
}