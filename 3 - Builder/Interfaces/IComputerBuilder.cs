using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
