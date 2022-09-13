using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Concretes
{
    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe? _instance;

        private static readonly object _lock = new object();

        public string? Value { get; set; }

        private SingletonThreadSafe() 
        {
        }

        public static SingletonThreadSafe GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadSafe();

                        _instance.Value = value;
                    }
                }
            }

            return _instance;
        }
    }
}
