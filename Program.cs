
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {



        static void Main(string[] args)
        {

            string[] Arr = new string []{ "flower","flow", "flight" };

            LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();

            var x=  longestCommonPrefix.longestCommonPrefix_B(Arr);

            Console.ReadLine();

        }
    }
}
