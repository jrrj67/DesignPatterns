namespace FactoryMethod.Games
{
    public abstract class Game
    {
        public string? Name { get; protected set; }

        public abstract string GetMainCharacter();
    }
}
