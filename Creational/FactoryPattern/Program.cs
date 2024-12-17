// See https://aka.ms/new-console-template for more information

using FactoryPattern;

IGameFactory gameFactory = new GameFactory();

var game = gameFactory.Create(GameTypes.Arcade);
game.Play();
game = gameFactory.Create(GameTypes.Shooter);
game.Play();
game = gameFactory.Create(GameTypes.Sports);
game.Play();

Console.WriteLine("You played all the games");