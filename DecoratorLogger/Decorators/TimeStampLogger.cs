using System;

namespace DecoratorLogger.Decorators
{
    public class TimeStampLogger : ILogger
    {
        private readonly ILogger innerLogger;

        public TimeStampLogger(ILogger innerLogger)
        {
            this.innerLogger = innerLogger;
        }

        public void Log(Severity severity, string message)
        {
            innerLogger.Log(severity, $"{DateTime.Now} {message}");
        }
    }
}
