using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Class
{
    public class SingletonClass
    {
        public static SingletonClass Initialize { get; } = new SingletonClass();

        private SingletonClass()
        {
            // Initialize.
        }
    }
}
