using Interfaces;

namespace AbstractFactory.Concretes.Xbox
{
    public class XboxFactory : IAbstractFactory
    {
        public IConsole CreateConsole()
        {
            return new XboxConsole();
        }

        public IController CreateController()
        {
            return new XboxController();
        }
    }
}
