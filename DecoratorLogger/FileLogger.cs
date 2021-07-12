using System.IO;

namespace DecoratorLogger
{
    public class FileLogger : ILogger
    {
        public string Path { get; private set; }

        public FileLogger(string path)
        {
            Path = $"{path}\\log.txt";

            if (File.Exists(Path))
            {
                File.WriteAllText(Path, "");
            }
        }

        public void Log(Severity severity, string message)
        {
            File.AppendAllText(Path, message);
        }
    }
}
