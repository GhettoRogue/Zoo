namespace ZooParkApp.loggers;

public class LogToConsole : ILogger
{
    private void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"{DateTime.Now:g} {message}");
        Console.ResetColor();
    }
    
    public void Info(string message)
    {
        Print($"[{nameof(Info).ToUpper()}] {message}", ConsoleColor.Blue);
    }

    public void Error(string message)
    {
        Print($"[{nameof(Error).ToUpper()}] {message}", ConsoleColor.Red);
    }

    public void Success(string message)
    {
        Print($"[{nameof(Success).ToUpper()}] {message}", ConsoleColor.Green);
    }
}