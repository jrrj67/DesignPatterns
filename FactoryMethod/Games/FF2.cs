namespace FactoryMethod.Games
{
    public sealed class FF2 : Game
    {
        public FF2()
        {
            Name = "Final Fantasy II";
        }

        public override string GetMainCharacter()
        {
            return "Firion";
        }
    }
}
