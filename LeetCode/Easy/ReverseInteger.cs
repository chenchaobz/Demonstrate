using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseInteger
    {

        int max = 214748364;
        int min = -214748364;
      

        public int Reverse_A(int x)
        {

            int res = 0;
            for (; ; )
            {
                if (x / 10 == 0)
                {
                    //边界值判断
                    if (x > 0 && (res > max || res == max && x > 7) || x < 0 && (res < min || res == min && x < -8))
                        return 0;

                    res = res * 10 + x;
                    break;
                }
                else
                {
                    res = res * 10 + x % 10;
                }

                x = x / 10;
            }


            return res;



        }



        public int Reverse_B(int x)
        {
            bool flag = x < 0 ? true : false;
            string intStr = x.ToString().Replace("-", "");
            string outStr = "";
            foreach (var item in intStr)
            {
                outStr = item + outStr;
            }
            if (int.TryParse(outStr, out int num))
            {
                return flag ? -num : num;
            }
            else
            {
                return 0;
            }
        }
    }
}
