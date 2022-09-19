using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Concretes
{
    public class FinalFantasyVIIIntergrade : FinalFantasyVII
    {
        public FinalFantasyVIIIntergrade()
        {
            Title = "Final Fantasy VII Intergrade";
        }

        public void PlayWithYuffie()
        {
            Console.WriteLine("Playing with Yuffie!");
        }
    }
}
