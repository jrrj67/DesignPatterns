using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Concretes
{
    public class SingletonNotThreadSafe
    {
        private static SingletonNotThreadSafe? _instance;

        private SingletonNotThreadSafe()
        {
        }

        public static SingletonNotThreadSafe GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonNotThreadSafe();
            }

            return _instance;
        }
    }
}
