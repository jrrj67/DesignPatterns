namespace FactoryMethod.Games
{
    public sealed class FF1 : Game
    {
        public FF1()
        {
            Name = "Final Fantasy I";
        }

        public override string GetMainCharacter()
        {
            return "Garland";
        }
    }
}
