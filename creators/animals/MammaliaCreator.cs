using ZooParkApp.animals;

namespace ZooParkApp.creators;

public class MammaliaCreator : AnimalCreator
{
    public override Animal Create(string kind)
    {
        return new Mammalia(kind);
    }
}