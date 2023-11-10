using ZooParkApp.animals;

namespace ZooParkApp.aviaries;

public abstract class Aviary
{
    public readonly int totalCount;
    public readonly List<Animal> animals;

    protected Aviary(int count)
    {
        totalCount = count;
        animals = new List<Animal>(totalCount);
    }

    public abstract bool AddAnimal(Animal animal);

    protected bool IsFree()
    {
        return animals.Count < totalCount;
    }
}