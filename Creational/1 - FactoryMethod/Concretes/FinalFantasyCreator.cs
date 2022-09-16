using Interfaces;

namespace Concretes
{
    public abstract class FinalFantasyCreator
    {
        public abstract IFinalFantasy FactoryMethod();

        public (string Title, string Protagonist) GetTitleAndProtagonist()
        {
            var ff = FactoryMethod();

            return (ff.Title, ff.Protagonist);
        }
    }
}
