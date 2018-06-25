using MyRegex.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyRegex.Implement
{
    public class ARegex : IMyRegex
    {

        public bool IsMatch(string input, string[] result)
        {
            // 這裡去設定 要檢查的邏輯
            Regex regex = new Regex(@"AAA");
            Match match = regex.Match(input);

            if (match.Success)
            {
                result[0] = input;
                return true;
            }

            return false;
        }
    }
}
