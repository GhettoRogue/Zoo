using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public class InsectCreator : AnimalCreator
{
    public override Animal Create()
    {
        return new Insect { Kind = Kind };
    }
}