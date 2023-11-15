using ZooParkApp.models.interfaces;

namespace ZooParkApp.models.animals;

public class Mammalia : Animal, IWalking
{
    public string Walking()
    {
        return "Walking";
    }
}