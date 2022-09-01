using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class FinalFantasyCreator
    {
        public abstract IFinalFantasy FactoryMethod();

        public (string Title, string Protagonist) GetTitleAndProtagonist()
        {
            var ff = FactoryMethod();
           
            return (ff.Title, ff.Protagonist);
        }
    }
}
