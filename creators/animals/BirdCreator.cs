using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public class BirdCreator : AnimalCreator
{
    public BirdCreator(string kind) : base(kind)
    {
    }
    
    public override Animal Create()
    {
        return new Bird(Kind);
    }
}