namespace Practice.Task2
{

    interface ILogger
    {
        void Trace(string message)
        { }
        void Info(string message)
        { }
        void Warning(string message)
        { }
        void Error(string message)
        { }
        void Fatal(string message)
        { }
        void Log(string message,  LogLevel)
        { }
    }
    class FileLogger : ILogger
    {

    }
    class ConsoleLogger : ILogger
    {

    }
}