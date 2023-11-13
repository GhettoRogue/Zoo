using ZooParkApp.loggers;
using ZooParkApp.models.aviaries;

namespace ZooParkApp.creators.aviaries;

public abstract class AviaryCreator : ICreator<Aviary>
{
    protected readonly string Name;
    protected readonly int Count;

    protected readonly ILogger? Logger;

    protected AviaryCreator(string name, int count, ILogger? logger = null)
    {
        this.Name = name;
        this.Count = count;

        Logger = logger;
    }

    public abstract Aviary Create();
}