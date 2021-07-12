namespace DecoratorLogger
{
    public interface ILogger
    {
        public void Log(Severity severity, string message);
    }
}
