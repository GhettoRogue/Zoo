using ZooParkApp.animals;

namespace ZooParkApp.creators;

public abstract class AnimalCreator
{
    public abstract Animal Create(string kind);
}