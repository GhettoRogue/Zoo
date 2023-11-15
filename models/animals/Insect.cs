using ZooParkApp.models.interfaces;

namespace ZooParkApp.models.animals;

public class Insect : Animal, IWalking, IFlying
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