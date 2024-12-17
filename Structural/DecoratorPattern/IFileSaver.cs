namespace DecoratorPattern;

public interface IFileSaver
{
    void save(string path, string content);
}