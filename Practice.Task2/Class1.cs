using static System.Net.Mime.MediaTypeNames;

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
    void Log(string message);
  }
  class FileLogger : ILogger
  {
    const string path = "logfile.txt";
    public void Log(string message)
    {
      File.WriteAllText(path, message);
    }
  }
  class ConsoleLogger : ILogger
  {
    public void Log(string message)
    {
      Console.WriteLine(message);
    }
  }
}