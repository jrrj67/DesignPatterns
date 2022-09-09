using AbstractFactory.Concretes.Playstation;
using AbstractFactory.Concretes.Xbox;
using Interfaces;

Console.WriteLine("Choose a console to play!");

Console.WriteLine("1 - Playstation");

Console.WriteLine("2 - Xbox");

int.TryParse(Console.ReadLine(), out int input);

IAbstractFactory? factory = null;

IConsole? console = null;

IController? controller = null;

switch (input)
{
    case 1:
        factory = new PlaystationFactory();

        console = factory.CreateConsole();

        controller = factory.CreateController();

        break;
    case 2:
        factory = new XboxFactory();

        console = factory.CreateConsole();

        controller = factory.CreateController();

        break;
}

if (console != null && controller != null)
{
    console.TurnOn();

    console.ChooseGame();

    console.Play();

    controller.PressButton();

    console.TurnOff();
}
