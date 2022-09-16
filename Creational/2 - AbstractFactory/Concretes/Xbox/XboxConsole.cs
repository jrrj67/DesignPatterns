using Interfaces;

namespace AbstractFactory.Concretes.Xbox
{
    public class XboxConsole : IConsole
    {
        public string Name { get; set; } = "Xbox One Series X";

        public void ChooseGame()
        {
            Console.WriteLine("Choosing Halo.");
        }

        public void Play()
        {
            Console.WriteLine("Playing Halo, hi Chief.");
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
