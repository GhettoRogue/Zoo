using ZooParkApp.aviaries;

namespace ZooParkApp.creators.aviaries;

public abstract class AviaryCreator
{
    public abstract Aviary Create(int count);
}