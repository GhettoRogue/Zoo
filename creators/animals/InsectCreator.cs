using ZooParkApp.models.animals;

namespace ZooParkApp.creators.animals;

public class InsectCreator : AnimalCreator
{
    public InsectCreator(string kind) : base(kind)
    {
    }

    public override Animal Create()
    {
        return new Insect(Kind);
    }
}