using Algorithm;
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


            ReverseInteger reverseInteger = new ReverseInteger();
            int reverseInteger_test1 = reverseInteger.Reverse_A(-2147483412);
            Console.WriteLine("输入：123，输出："+reverseInteger_test1);
            //int reverseInteger_test2 = reverseInteger.Reverse_A(-1);
            //Console.WriteLine("输入：-123，输出：" + reverseInteger_test2);
            //int reverseInteger_test3 = reverseInteger.Reverse_A(4);
            //Console.WriteLine("输入：120，输出：" + reverseInteger_test3);
            //Console.WriteLine(length);
            Console.ReadLine();

        }
    }
}
