using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public abstract class AnimalCreator : ICreator<Animal>
{
    protected readonly string Kind;

    protected AnimalCreator(string kind)
    {
        this.Kind = kind;
    }

    public abstract Animal Create();
}