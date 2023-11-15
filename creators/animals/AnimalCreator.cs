using ZooParkApp.loggers;
using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public abstract class AnimalCreator : ICreator<Animal>
{
    public string Kind { get; init; }

    public ILogger? Logger { get; init; }
    public abstract Animal Create();
}