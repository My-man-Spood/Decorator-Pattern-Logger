namespace DecoratorLogger.Decorators
{
    public class SeverityBumperLogger : ILogger
    {
        private readonly ILogger innerLogger;

        public SeverityBumperLogger(ILogger innerLogger)
        {
            this.innerLogger = innerLogger;
        }

        public void Log(Severity severity, string message)
        {
            if(message.StartsWith("!"))
            {
                severity = Severity.Error;
            }

            innerLogger.Log(severity, message);
        }
    }
}
