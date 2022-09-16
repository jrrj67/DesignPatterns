using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Concretes
{
    public sealed class Playstation : ICloneable<Playstation>
    {
        public string Model { get; private set; }

        public int Version { get; private set; }

        public Controller Controller { get; private set; }

        public Playstation(string model, int version, Controller controller)
        {
            Model = model;
            Version = version;
            Controller = controller;
        }

        public Playstation ShallowCopy()
        {
            return (Playstation)MemberwiseClone();
        }

        public Playstation DeepCopy()
        {
            var clone = ShallowCopy();

            clone.Model = new string(Model);

            clone.Controller = new Controller(Controller.Name, Controller.Buttons);

            return clone;
        }
    }
}
