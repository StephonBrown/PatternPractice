using FactoryPattern.Games;

namespace FactoryPattern;

class GameFactory : IGameFactory
{

    public IGame Create(GameTypes gameType)
    {
        switch (gameType)
        {
            case GameTypes.Sports:
                return new Sports();
            case GameTypes.Arcade:
                return new Arcade();
            case GameTypes.Shooter:
                return new Shooter();
            default:
                throw new ArgumentOutOfRangeException(nameof(gameType), gameType, null);
        }
    }
}