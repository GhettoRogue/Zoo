using ZooParkApp.aviaries;

namespace ZooParkApp.creators.aviaries;

public class AquaAviaryCreator : AviaryCreator
{
    public override Aviary Create(int count)
    {
        return new AquaAviary(count);
    }
}