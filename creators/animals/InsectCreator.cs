using ZooParkApp.animals;

namespace ZooParkApp.creators;

public class InsectCreator : AnimalCreator
{
    public override Animal Create(string kind)
    {
        return new Insect(kind);
    }
}