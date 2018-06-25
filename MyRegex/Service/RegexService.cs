using MyRegex.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRegex.Service
{
    public class RegexService
    {
        private List<IMyRegex> _myRegices;

        /// <summary>
        /// 從外部決定 哪些 Regex 要判斷
        /// </summary>
        /// <param name="myRegices"></param>
        public RegexService(List<IMyRegex> myRegices)
        {
            _myRegices = myRegices;
        }

        //public 
        public string[] GetResult(string input, string[] result)
        {
            foreach (var item in _myRegices)
            {
                item.IsMatch(input, result);                
            }

            return result;
        }
    }
}
