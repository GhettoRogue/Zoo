namespace ZooParkApp.loggers;

public class LogToFile : ILogger
{
    private readonly string _path;

    public LogToFile(string path)
    {
        _path = path;
    }

    public void Info(string message)
    {
        Write($"[{nameof(Info).ToUpper()}] {message}");
    }

    public void Error(string message)
    {
        Write($"[{nameof(Error).ToUpper()}] {message}");
    }

    public void Success(string message)
    {
        Write($"[{nameof(Success).ToUpper()}] {message}");
    }

    private void Write(string message)
    {
        using var file = new StreamWriter(_path, true);
        file.WriteLine($"{DateTime.Now:g} {message}");
    }
}