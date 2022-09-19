using Adapter.Concretes;
using Adapter.Interfaces;

Console.WriteLine("Choose which version of FFVII to play!");

Console.WriteLine("1 - Playsation");

Console.WriteLine("2 - Computer");

int.TryParse(Console.ReadLine(), out int input);

IFinalFantasyVII? platorm = null;

if (input == 1)
{
    platorm = new Playstation();
}
else if (input == 2)
{
    Computer computer = new();

    platorm = new ComputerAdapter(computer);
}

if (platorm is not null)
    platorm.Interact();