namespace ZooParkApp.loggers;

public class LogToFile : ILogger
{
    private readonly string _path;

    public LogToFile(string path)
    {
        this._path = path;
    }

    private void Write(string message)
    {
        using var file = new StreamWriter(_path, append: true);
        file.WriteLine($"{DateTime.Now:g} {message}");
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
}