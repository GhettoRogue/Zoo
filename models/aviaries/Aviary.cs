using ZooParkApp.models.animals;

namespace ZooParkApp.models.aviaries;

public abstract class Aviary
{
    public string Name { get; init; }
    public int TotalCount { get; init; }
    public List<Animal> Animals { get; init; } = new();
    public bool IsFree => Animals.Count < TotalCount;

    public abstract bool AddAnimal(Animal animal);
}