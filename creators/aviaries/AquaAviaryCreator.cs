using ZooParkApp.loggers;
using ZooParkApp.models.aviaries;

namespace ZooParkApp.creators.aviaries;

public class AquaAviaryCreator : AviaryCreator
{
    public AquaAviaryCreator(string name, int count) : base(name, count)
    {
    }

    public AquaAviaryCreator(string name, int count, ILogger? logger) : base(name, count, logger)
    {
    }

    public override Aviary Create()
    {
        var aviary = new AquaAviary(Name, Count);
        Logger?.Info($"Создан вольер {aviary.GetType().Name}, {Name} ({Count})");
        return aviary;
    }
}