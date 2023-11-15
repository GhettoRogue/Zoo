using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public class BirdCreator : AnimalCreator
{
    public override Animal Create()
    {
        return new Bird { Kind = Kind };
    }
}