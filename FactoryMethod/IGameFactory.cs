using FactoryMethod.Games;

namespace FactoryMethod
{
    public interface IGameFactory
    {
        public Game CreateGame(int code);
    }
}
