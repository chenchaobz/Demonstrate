using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class ThirdMaximumNumber
    {


        public int ThirdMax_A(int[] nums)
        {

            int? max_first = null;
            int? max_second = null;
            int? max_thrid = null;
            for (var i = 0; i < nums.Length; i++)
            {

                if (max_first == null || nums[i] > max_first)
                {
                    if (max_second == null || max_second < max_first)
                    {
                        if (max_thrid == null || max_thrid < max_second)
                            max_thrid = max_second;
                        max_second = max_first;
                    }

                    max_first = nums[i];
                }

                else if ((max_second == null || max_second < nums[i]) && nums[i] != max_first)
                {
                    if (max_thrid == null || max_thrid < max_second)
                        max_thrid = max_second;
                    max_second = nums[i];
                }
                else if (nums[i] < max_second && (max_thrid == null || max_thrid < nums[i]) && nums[i] != max_first)
                    max_thrid = nums[i];

            }


            if (max_thrid != null)
                return max_thrid.Value;
            else
                return max_first.Value;

            //初始代码，未考虑数组排序方向对结果的影响。if判断条件较复杂
            //null 每次赋值都存在装箱和拆箱导致效率低下

        }

        public int ThirdMax_B(int[] nums)
        {
            var n = nums.Length;

            if (n == 1) return nums[0];

            var max1 = long.MinValue;
            var max2 = long.MinValue;
            var max3 = long.MinValue;

            foreach (var cur in nums)
            {
                if (max1 < cur)
                {
                    //使用long.MinValue，避免了null与有值的区别
                    max3 = max2;
                    max2 = max1;
                    max1 = cur;
                }
                else if (max1 != cur && max2 < cur)
                {
                    max3 = max2;
                    max2 = cur;
                }
                else if (max2 != cur && cur < max1 && max3 < cur)
                {
                    max3 = cur;
                }
            }

            return (int)(max3 == long.MinValue ? max1 : max3);

        }
    }
}
