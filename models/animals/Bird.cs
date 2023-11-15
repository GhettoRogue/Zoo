using ZooParkApp.models.interfaces;

namespace ZooParkApp.models.animals;

public class Bird : Animal, IFlying, IWalking
{
    public string Flying()
    {
        return "Flying";
    }

    public string Walking()
    {
        return "Walking";
    }
}