using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class CountPrimes
    {

        public int CountPrimes_A(int n)
        {
            int primesCount = 0;

            for (var i = 2; i < n; i++)
            {
                if (IsPrime(i))
                    primesCount++;
            }


            return primesCount;
        }


        public bool IsPrime(int n)
        {
            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
