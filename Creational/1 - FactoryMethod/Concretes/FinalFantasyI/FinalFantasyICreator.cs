using Concretes;
using Interfaces;

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
