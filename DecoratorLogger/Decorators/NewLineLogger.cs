using System;
namespace DecoratorLogger.Decorators
{
    public class NewLineLogger : ILogger
    {
        private ILogger innerLogger;

        public NewLineLogger(ILogger innerLogger)
        {
            this.innerLogger = innerLogger;
        }

        public void Log(Severity severity, string message)
        {
            innerLogger.Log(severity, $"{message}\n");
        }
    }
}
