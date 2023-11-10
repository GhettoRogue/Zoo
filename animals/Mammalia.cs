using ZooParkApp.interfaces;

namespace ZooParkApp.animals;

public class Mammalia : Animal, IWalking
{
    public Mammalia(string kind) : base(kind)
    {
    }

    public string Walking()
    {
        return "Walking";
    }
}