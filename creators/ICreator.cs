using ZooParkApp.loggers;

namespace ZooParkApp.creators;

public interface ICreator<out T>
{
    public ILogger? Logger { get; init; }
    public T Create();
}