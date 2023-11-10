using ZooParkApp.animals;
using ZooParkApp.interfaces;

namespace ZooParkApp.aviaries;

public class AquaAviary : Aviary
{
    public AquaAviary(int totalCount) : base(totalCount)
    {
    }

    public override bool AddAnimal(Animal animal)
    {
        if (!IsFree()) return false;

        if (animal is not ISwimming) return false;
        
        animals.Add(animal);
        return true;
    }
}