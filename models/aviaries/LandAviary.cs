using ZooParkApp.models.animals;
using ZooParkApp.models.interfaces;

namespace ZooParkApp.models.aviaries;

public class LandAviary : Aviary
{
    public LandAviary(string name, int count) : base(name, count)
    {
    }

    public override bool AddAnimal(Animal animal)
    {
        if (!IsFree()) return false;

        if (animal is not (IFlying or IWalking)) return false;
        
        Animals.Add(animal);
        return true;
    }
}