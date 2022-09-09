namespace Interfaces
{
    public interface IConsole
    {
        public string Name { get; set; }

        public void TurnOn();

        public void TurnOff();

        public void ChooseGame();

        public void Play();
    }
}
