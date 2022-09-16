using Interfaces;

namespace AbstractFactory.Concretes.Playstation
{
    public class PlaystationConsole : IConsole
    {
        public string Name { get; set; } = "Playstation 5";

        public void ChooseGame()
        {
            Console.WriteLine("Choosing Final Fantasy 16.");
        }

        public void Play()
        {
            Console.WriteLine("Playing Final Fantasy 16, hi Clive.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turning off {Name}.");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turning on {Name}.");
        }
    }
}
