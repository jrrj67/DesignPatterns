using Bridge.Interfaces;

namespace Bridge.Concretes
{
    public class ComputerVersion : IPlayFinalFantasy
    {
        private readonly FinalFantasyVII _finalFantasy;

        public ComputerVersion(FinalFantasyVII finalFantasy)
        {
            _finalFantasy = finalFantasy;
        }

        public void Play()
        {
            Console.WriteLine($"Playing {_finalFantasy.Title} through PC!");
        }
    }
}
