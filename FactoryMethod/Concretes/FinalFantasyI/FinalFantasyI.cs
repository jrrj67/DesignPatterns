using Interfaces;

namespace FactoryMethod.Concretes.FinalFantasyI
{
    public class FinalFantasyI : IFinalFantasy
    {
        public string Title { get; }

        public string Protagonist { get; }

        public FinalFantasyI(string title, string protagonist)
        {
            Title = title;
            Protagonist = protagonist;
        }
    }
}
