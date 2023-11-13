using ZooParkApp.loggers;
using ZooParkApp.models.aviaries;

namespace ZooParkApp.creators.aviaries;

public class LandAviaryCreator : AviaryCreator
{
    public LandAviaryCreator(string name, int count) : base(name, count)
    {
    }

    public LandAviaryCreator(string name, int count, ILogger? logger) : base(name, count, logger)
    {
    }

    public override Aviary Create()
    {
        var aviary = new LandAviary(Name, Count);
        Logger?.Info($"Создан вольер {aviary.GetType().Name}, {Name} ({Count})");
        return aviary;
    }
}