using Interfaces;

namespace AbstractFactory.Concretes.Xbox
{
    public class XboxController : IController
    {
        public string Name { get; set; } = "Xbox Wireless Controller";

        public void PressButton()
        {
            Console.WriteLine($"{Name} pressing LB.");
        }
    }
}
