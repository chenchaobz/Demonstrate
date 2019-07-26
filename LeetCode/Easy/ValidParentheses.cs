using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidParentheses
    {

        public bool IsValid(string s)
        {
            int pLength = s.Length;
            if (pLength % 2 != 0)
                return false;
            while (s.Length >0)
            {
                s = s.Replace("()","").Replace("{}","").Replace("[]","");
                if (s.Length == pLength)
                    return false;
                pLength = s.Length;
            }
            return true;
        }
    }
}
