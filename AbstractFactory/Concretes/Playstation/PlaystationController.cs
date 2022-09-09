using Interfaces;

namespace AbstractFactory.Concretes.Playstation
{
    public class PlaystationController : IController
    {
        public string Name { get; set; } = "Dualsense";

        public void PressButton()
        {
            Console.WriteLine($"{Name} pressing R1.");
        }
    }
}
