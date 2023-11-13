namespace ZooParkApp.creators;

public interface ICreator<out T>
{
    public T Create();
}