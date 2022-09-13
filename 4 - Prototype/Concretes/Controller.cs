using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Concretes
{
    public sealed class Controller
    {
        public string Name { get; set; }

        public int Buttons { get; set; }

        public Controller(string name, int buttons)
        {
            Name = name;
            Buttons = buttons;
        }
    }
}
