namespace ZooParkApp.animals;

public abstract class Animal
{
    public readonly string kind;

    protected Animal(string kind)
    {
        this.kind = kind;
    }
}