using System;

namespace DecoratorLogger.Decorators
{
    public class ConsoleLogger : ILogger
    {
        private readonly ILogger innerLogger;

        public ConsoleLogger(ILogger innerLogger)
        {
            this.innerLogger = innerLogger;
        }

        public void Log(Severity severity, string message)
        {
            innerLogger.Log(severity, message);
            Console.WriteLine(message);
        }
    }
}
