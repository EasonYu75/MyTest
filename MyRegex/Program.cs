using MyRegex.Implement;
using MyRegex.Interface;
using MyRegex.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] result = new string[5];

            List<IMyRegex> regices = new List<IMyRegex>();
            regices.Add(new ARegex());
            regices.Add(new BRegex());

            // 從外部決定 哪些 Regex 要判斷，由建構子傳入
            RegexService regexService = new RegexService(regices);
            regexService.GetResult("AAA", result);

            Console.ReadLine();
        }
    }
}
