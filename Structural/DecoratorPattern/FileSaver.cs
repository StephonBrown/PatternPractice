namespace DecoratorPattern;

class FileSaver : IFileSaver
{
    public void save(string path, string content)
    {
        Console.WriteLine("File saved!");
    }
}