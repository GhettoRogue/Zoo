namespace ZooParkApp.loggers;

public interface ILogger
{
    public void Info(string message);
    public void Error(string message);
    public void Success(string message);
}