using ZooParkApp.animals;

namespace ZooParkApp.creators;

public class BirdCreator : AnimalCreator
{
    public override Animal Create(string kind)
    {
        return new Bird(kind);
    }
}