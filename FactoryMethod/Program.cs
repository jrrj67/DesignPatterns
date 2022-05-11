using FactoryMethod;

var games = new string[]
{
    "1 - Final Fantasy I",
    "2 - Final Fantasy II",
};

Console.WriteLine("Select your favorite FF:");

foreach (var game in games)
{
    Console.WriteLine(game);
}

int input;

int.TryParse(Console.ReadLine(), out input);

var factory = new GameFactory();

var createdGame = factory.CreateGame(input);

var mainCharacter = createdGame.GetMainCharacter();

Console.Write("Main character of game: ");

Console.WriteLine(mainCharacter);