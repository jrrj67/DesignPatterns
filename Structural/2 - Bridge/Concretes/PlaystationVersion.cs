using Bridge.Interfaces;

namespace Bridge.Concretes
{
    public class PlaystationVersion : IPlayFinalFantasy
    {
        private readonly FinalFantasyVIIIntergrade _finalFantasy;

        public PlaystationVersion(FinalFantasyVIIIntergrade finalFantasy)
        {
            _finalFantasy = finalFantasy;
        }

        public void Play()
        {
            Console.WriteLine($"Playing {_finalFantasy.Title} through Sony system!");

            _finalFantasy.PlayWithYuffie();
        }
    }
}
