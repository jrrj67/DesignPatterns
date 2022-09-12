using Builder.Interfaces;

namespace Builder.Concretes
{
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new();

        public ComputerBuilder()
        {
            Reset();
        }

        public void AddCPU(string cpu)
        {
            _computer.CPU = cpu;
        }

        public void AddHD(string hd)
        {
            _computer.HD = hd;
        }

        public void AddRAM(string ram)
        {
            _computer.RAM = ram;
        }

        public void AddSSD(string ssd)
        {
            _computer.SSD = ssd;
        }

        public void AddVideoCard(string videoCard)
        {
            _computer.VideoCard = videoCard;
        }

        public Computer GetComputer()
        {
            var result = _computer;

            Reset();

            return result;
        }

        public void Reset()
        {
            _computer = new();
        }
    }
}
