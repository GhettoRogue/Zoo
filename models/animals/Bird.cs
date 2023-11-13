using ZooParkApp.models.interfaces;

namespace ZooParkApp.models.animals;

public class Bird : Animal, IFlying, IWalking
{
    public Bird(string kind) : base(kind)
    {
    }

    public string Flying()
    {
        return "Flying";
    }

    public string Walking()
    {
        return "Walking";
    }
}