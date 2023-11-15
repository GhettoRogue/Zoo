using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public class MammaliaCreator : AnimalCreator
{
    public override Animal Create()
    {
        return new Mammalia { Kind = Kind };
    }
}