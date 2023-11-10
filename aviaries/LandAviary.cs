using ZooParkApp.animals;
using ZooParkApp.interfaces;

namespace ZooParkApp.aviaries;

public class LandAviary : Aviary
{
    public LandAviary(int count) : base(count)
    {
    }

    public override bool AddAnimal(Animal animal)
    {
        if (!IsFree()) return false;

        if (animal is not (IFlying or IWalking)) return false;
        
        animals.Add(animal);
        return true;
    }
}