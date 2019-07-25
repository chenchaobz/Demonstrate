using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class RomanToInt
    {
        public int RomanToInt_A(string s)
        {
            int value = 0, tmp = 0, baseValue = 0; ;
            for (var i = 0; i < s.Length; i++)
            {
                baseValue = BaseValue(s[i]);
                if (tmp != 0 && tmp < baseValue)
                {
                    value += baseValue - 2*tmp;
                }
                else
                    value += baseValue;
                tmp = baseValue;
            }
            return value;
        }


        public int BaseValue(char s)
        {
            switch (s)
            {
                case 'I':
                 return 1;     
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
              
            }
            return 0;
        }
    }
}
