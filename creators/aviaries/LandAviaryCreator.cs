using ZooParkApp.aviaries;

namespace ZooParkApp.creators.aviaries;

public class LandAviaryCreator : AviaryCreator
{
    public override Aviary Create(int count)
    {
        return new LandAviary(count);
    }
}