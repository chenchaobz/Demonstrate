using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeNumber
    {
        public bool IsPalindrome_A(int x)
        {
            var str = x.ToString();
            for (var i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            }
            return true;
        }


        public bool IsPalindrome_B(int x)
        {
            if (x < 0) return false;

            long num = (long)x;
            long reversedNum = 0;
            while (num > 0)
            {
                reversedNum = reversedNum * 10 + num % 10;
                num /= 10;
            }

            if (reversedNum == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
