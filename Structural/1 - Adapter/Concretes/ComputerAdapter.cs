using Adapter.Interfaces;

namespace Adapter.Concretes
{
    public class ComputerAdapter : IFinalFantasyVII
    {
        private readonly Computer _computer;

        public ComputerAdapter(Computer computer)
        {
            _computer = computer;
        }

        public void Interact()
        {
            _computer.InteractWithY();
        }
    }
}
