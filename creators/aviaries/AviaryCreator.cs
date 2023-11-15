using ZooParkApp.loggers;
using ZooParkApp.models.aviaries;

namespace ZooParkApp.creators.aviaries;

public abstract class AviaryCreator : ICreator<Aviary>
{
    public string Name { get; init; }
    public int Count { get; init; }

    public ILogger? Logger { get; init; }
    public abstract Aviary Create();
}