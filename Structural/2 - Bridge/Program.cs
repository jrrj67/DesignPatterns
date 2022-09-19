using Bridge.Concretes;
using Bridge.Interfaces;

Console.WriteLine("Choose a platform to play FF!");

Console.WriteLine("1 - Playstation");

Console.WriteLine("2 - PC");

int.TryParse(Console.ReadLine(), out int result);

var ff = new FinalFantasyVII();

var integrade = new FinalFantasyVIIIntergrade();

IPlayFinalFantasy? playable = null;

if (result == 1)
{
    playable = new PlaystationVersion(integrade);
}
else if (result == 2)
{
    playable = new ComputerVersion(ff);
}

if (playable is not null)
    playable.Play();