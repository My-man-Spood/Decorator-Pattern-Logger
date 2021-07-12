using System;

namespace DecoratorLogger.Decorators
{
    public class SeverityInfoLogger : ILogger
    {
        private ILogger innerLogger;

        public SeverityInfoLogger(ILogger innerLogger) 
        {
            this.innerLogger = innerLogger;
        }

        public void Log(Severity severity, string message)
        {
            innerLogger.Log(severity, $"[{severity}] {message}");
        }
    }
}
