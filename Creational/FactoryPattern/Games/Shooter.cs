namespace FactoryPattern.Games;

class Shooter : IGame
{
    public void Play()
    {
        Console.WriteLine("Pow");
    }
}