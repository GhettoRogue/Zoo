using ZooParkApp.models.interfaces;

namespace ZooParkApp.models.animals;

public class Fish : Animal, ISwimming
{
    public string Swimming()
    {
        return "swimming";
    }
}