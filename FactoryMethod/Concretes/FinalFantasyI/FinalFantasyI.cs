using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concretes.FinalFantasyI
{
    public class FinalFantasyI : IFinalFantasy
    {
        public string Title { get; }

        public string Protagonist { get; }

        public FinalFantasyI(string title, string protagonist)
        {
            Title = title;
            Protagonist = protagonist;
        }
    }
}
