namespace ZooParkApp.models.animals;

public abstract class Animal
{
    public readonly string Kind;

    protected Animal(string kind)
    {
        this.Kind = kind;
    }
}