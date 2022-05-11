using FactoryMethod.Games;

namespace FactoryMethod
{
    public class GameFactory : IGameFactory
    {
        public Game CreateGame(int code)
        {
            Game? game = null;

            switch (code)
            {
                case (int)GamesEnum.FF1:
                    game = new FF1();
                    break;
                case (int)GamesEnum.FF2:
                    game = new FF2();
                    break;
            }

            if (game is null)
                throw new Exception("Game can't be null!");

            return game;
        }
    }
}
