using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class Singletontest
    {
        private static Singletontest _instance;
        private static readonly object _locker = new object();
        private Singletontest() { }

        public static Singletontest Instance()
        {
            if (_instance == null)
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Singletontest();
                    }
                }
            }
            return _instance;
        }
    }
}
