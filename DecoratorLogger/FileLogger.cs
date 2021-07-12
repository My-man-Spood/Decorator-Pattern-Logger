using System.IO;

namespace DecoratorLogger
{
    public class FileLogger : ILogger
    {
        private string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public void Log(Severity severity, string message)
        {
            File.AppendAllText($"{path}/log.txt", message);
        }
    }
}
