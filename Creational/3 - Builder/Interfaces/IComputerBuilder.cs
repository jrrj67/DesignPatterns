namespace Builder.Interfaces
{
    public interface IComputerBuilder
    {
        void AddRAM(string ram);

        void AddCPU(string cpu);

        void AddVideoCard(string videoCard);

        void AddSSD(string ssd);

        void AddHD(string hd);
    }
}
