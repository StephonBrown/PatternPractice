namespace DecoratorPattern;

public class CompressFileSaver : IFileSaver
{
    private IFileSaver fileSaver;

    public CompressFileSaver(IFileSaver fileSaver)
    {
        this.fileSaver = fileSaver;
    }
    public void save(string path, string content)
    {
        CompressFile();
        fileSaver.save(path, content);
    }

    private void CompressFile()
    {
        Console.WriteLine("File compressed");
    }
}