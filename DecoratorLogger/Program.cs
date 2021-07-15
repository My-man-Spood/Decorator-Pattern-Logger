using System;

namespace DecoratorLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger(AppDomain.CurrentDomain.BaseDirectory);

            Console.WriteLine("Start typing: ");
            Console.WriteLine("");

            while (true)
            {
                var text = Console.ReadLine();
                logger.Log(Severity.Info, text);
            }
        }
    }
}
