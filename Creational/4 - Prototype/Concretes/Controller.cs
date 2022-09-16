namespace Prototype.Concretes
{
    public sealed class Controller
    {
        public string Name { get; set; }

        public int Buttons { get; set; }

        public Controller(string name, int buttons)
        {
            Name = name;
            Buttons = buttons;
        }
    }
}
