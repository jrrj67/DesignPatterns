using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concretes.FinalFantasyI
{
    public class FinalFantasyICreator : FinalFantasyCreator
    {
        public override IFinalFantasy FactoryMethod()
        {
            return new FinalFantasyI("Final Fantasy I", "Warrior of Light");
        }
    }
}
