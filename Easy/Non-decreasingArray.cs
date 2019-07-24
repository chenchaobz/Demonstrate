using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Non_decreasingArray
    {

        public bool CheckPossibility_A(int[] nums)
        {

            //未考虑账号替换情况，进行替换时，何时不满足条件理解不足
            //int mistakeCount = 0;
            //if (nums.Count() == 1)
            //    return true;
            //else
            //{
            //    for (var i = 0; i < nums.Count() - 2; i++)
            //    {
            //        if (nums[i + 1] < nums[i])
            //        {
            //            mistakeCount++;
            //        }
            //        if (mistakeCount >= 2)
            //            break;
            //    }
            //}
            //if (mistakeCount >= 2)
            //    return false;
            //else
            //    return true;



            if (nums == null)
                return true;

            var length = nums.Length;
            if (length == 1)
                return true;

            var count = 0;
            for (int i = 0; i < length; i++)
            {
                var current = nums[i];

                if (i + 1 < length && current > nums[i + 1])
                {
                    count++;
                    // two user cases: -1, 4, 2, 3, 
                    // index = 1, one is to replace index = 1 or index = 2
                    //   replace index = i + 1
                    if ((i + 2 < length && nums[i] > nums[i + 2]) &&
                       // replce index =  i
                       (i > 0 && nums[i - 1] > nums[i + 1]))
                    {
                        return false;
                    }
                }

                if (count >= 2)
                    return false;
            }

            return true;
        }

    }
}
