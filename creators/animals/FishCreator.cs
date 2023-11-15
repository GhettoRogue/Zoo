using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public class FishCreator : AnimalCreator
{
    public override Animal Create()
    {
        return new Fish { Kind = Kind };
    }
}