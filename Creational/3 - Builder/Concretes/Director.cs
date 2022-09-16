using Builder.Interfaces;

namespace Builder.Concretes
{
    public class Director
    {
        public IComputerBuilder _builder;

        public IComputerBuilder Builder
        {
            set { _builder = value; }
        }

        public Director(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildHighEndComputer()
        {
            _builder.AddRAM("20GB");

            _builder.AddVideoCard("RTX 3090 TI 24GB");

            _builder.AddSSD("5TB");

            _builder.AddCPU("Intel® Core™ i9");
        }

        public void BuildLowEndComputer()
        {
            _builder.AddRAM("4GB");

            _builder.AddHD("1TB");

            _builder.AddCPU("Intel® Core™ i3");
        }
    }
}
