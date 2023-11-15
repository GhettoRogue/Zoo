using ZooParkApp.models.aviaries;

namespace ZooParkApp.creators.aviaries;

public class AquaAviaryCreator : AviaryCreator
{
    public override Aviary Create()
    {
        var aviary = new AquaAviary { Name = Name, TotalCount = Count };
        Logger?.Info($"Создан вольер {aviary.GetType().Name}, {Name} ({Count})");
        return aviary;
    }
}