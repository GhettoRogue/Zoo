using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public class MammaliaCreator : AnimalCreator
{
    public MammaliaCreator(string kind) : base(kind)
    {
    }

    public override Animal Create()
    {
        return new Mammalia(Kind);
    }
}