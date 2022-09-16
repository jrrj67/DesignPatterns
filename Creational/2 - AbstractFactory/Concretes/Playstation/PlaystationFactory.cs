using Interfaces;

namespace AbstractFactory.Concretes.Playstation
{
    public class PlaystationFactory : IAbstractFactory
    {
        public IConsole CreateConsole()
        {
            return new PlaystationConsole();
        }

        public IController CreateController()
        {
            return new PlaystationController();
        }
    }
}
