using Builder.Concretes;
using Builder.Utils;

var builder = new ComputerBuilder();

var director = new Director(builder);

Console.WriteLine("Choose a computer to build:");

Console.WriteLine("1 - Low End computer.");

Console.WriteLine("2 - High End computer.");

int.TryParse(Console.ReadLine(), out int result);

if (result == (int)ComputerEnum.LOWEND)
{
    director.BuildLowEndComputer();

    var lowEndComputer = builder.GetComputer();

    Console.WriteLine(lowEndComputer);
}
else if (result == (int)ComputerEnum.HIGHEND)
{
    director.BuildHighEndComputer();

    var highEndComputer = builder.GetComputer();

    Console.WriteLine(highEndComputer);
}