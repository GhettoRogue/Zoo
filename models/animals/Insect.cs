using ZooParkApp.models.interfaces;

namespace ZooParkApp.models.animals;

public class Insect : Animal, IWalking, IFlying
{
    public Insect(string kind) : base(kind)
    {
    }

    public string Walking()
    {
        return "Walking";
    }

    public string Flying()
    {
        return "Flying";
    }
}