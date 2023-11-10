using ZooParkApp.animals;

namespace ZooParkApp.creators;

public class FishCreator : AnimalCreator
{
    public override Animal Create(string kind)
    {
        return new Fish(kind);
    }
}