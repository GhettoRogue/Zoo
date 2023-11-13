using ZooParkApp.models.animals;

namespace ZooParkApp.models.aviaries;

public abstract class Aviary
{
    public readonly string Name;
    public readonly int TotalCount;
    public readonly List<Animal> Animals;

    protected Aviary(string name, int count)
    {
        this.Name = name;
        TotalCount = count;
        Animals = new List<Animal>(TotalCount);
    }

    public abstract bool AddAnimal(Animal animal);

    protected bool IsFree()
    {
        return Animals.Count < TotalCount;
    }
}