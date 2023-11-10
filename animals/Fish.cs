using ZooParkApp.interfaces;

namespace ZooParkApp.animals;

public class Fish : Animal, ISwimming
{
    public Fish(string kind) : base(kind)
    {
    }

    public string Swimming()
    {
        return "swimming";
    }
}