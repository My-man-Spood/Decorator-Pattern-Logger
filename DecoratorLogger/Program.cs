using System;
using DecoratorLogger.Decorators;

namespace DecoratorLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger(AppDomain.CurrentDomain.BaseDirectory);
            logger = new ConsoleLogger(logger);
            logger = new NewLineLogger(logger);
            logger = new SeverityInfoLogger(logger);
            logger = new TimeStampLogger(logger);
            logger = new SeverityBumperLogger(logger);

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
