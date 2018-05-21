using Singleton.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // 第一次初始化，會調用初始化Method
            SingletonClass s = SingletonClass.Initialize;

            // 第二此以後初始化，就不會掉用初始化Method
            SingletonClass s2 = SingletonClass.Initialize;
        }
    }
}
