using Adapter.Interfaces;

namespace Adapter.Concretes
{
    public class Playstation : IFinalFantasyVII
    {
        public void Interact()
        {
            Console.WriteLine("Press triangle.");
        }
    }
}
