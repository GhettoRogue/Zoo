using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public class FishCreator : AnimalCreator
{
    public FishCreator(string kind) : base(kind)
    {
    }

    public override Animal Create()
    {
        return new Fish(Kind);
    }
}