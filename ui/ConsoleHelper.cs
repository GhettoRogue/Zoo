namespace ZooParkApp.ui;

public static class ConsoleHelper
{
    public static void SleepAndClear()
    {
        Print("Нажмите любую клавишу для продолжения...");
        Console.ReadKey();
        Console.Clear();
    }
    public static void Print(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(message);
        Console.ResetColor();
    }
    public static void PrintLine(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    
    public static void PrintError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"!!! {message} !!!");
        Console.ResetColor();
    }

    public static string InputString(string message)
    {
        Print(message);
        return Console.ReadLine();
    }

    public static int InputInt(string message)
    {
        return Convert.ToInt32(InputString(message));
    }
}