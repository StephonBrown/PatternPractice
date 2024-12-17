namespace DecoratorPattern;

public class EncryptFileSaver : IFileSaver
{
    private IFileSaver fileSaver;

    public EncryptFileSaver(IFileSaver fileSaver)
    {
        this.fileSaver = fileSaver;
    }
    public void save(string path, string content)
    {
        EncryptFile(content);
        fileSaver.save(path, content);
    }

    private void EncryptFile(string content)
    {
        Console.WriteLine("File encrypted");
    }
}