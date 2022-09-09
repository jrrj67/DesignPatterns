namespace Interfaces
{
    public interface IAbstractFactory
    {
        public IConsole CreateConsole();

        public IController CreateController();
    }
}
