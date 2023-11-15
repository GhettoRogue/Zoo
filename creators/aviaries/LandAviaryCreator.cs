using ZooParkApp.models.aviaries;

namespace ZooParkApp.creators.aviaries;

public class LandAviaryCreator : AviaryCreator
{
    public override Aviary Create()
    {
        var aviary = new LandAviary { Name = Name, TotalCount = Count };
        Logger?.Info($"Создан вольер {aviary.GetType().Name}, {Name} ({Count})");
        return aviary;
    }
}