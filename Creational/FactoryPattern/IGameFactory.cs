namespace FactoryPattern;

public interface IGameFactory
{
    IGame Create(GameTypes gameType);
}