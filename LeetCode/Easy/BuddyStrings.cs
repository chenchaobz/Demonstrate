using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BuddyStrings
    {
        /// <summary>
        /// 暴力解题，执行效率较低
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public bool BuddyStrings_A(string A, string B)
        {

            char[] arr_A = A.ToCharArray();
            int length_A = A.Length;
            char[] arr_B = B.ToCharArray();
            int length_B = B.Length;
            int markA = -1, markB = -1, mark_C = 0, diffCount = 0;
            if (length_A != length_B)
                return false;

            List<char> charList = new List<char>();

            for (var i = 0; i < length_A; i++)
            {
                if (charList.Contains(arr_A[i]))
                {
                    mark_C++;
                }
                else
                {
                    charList.Add(arr_A[i]);
                }


                if (arr_A[i] != arr_B[i])
                {
                    diffCount++;
                    if (diffCount == 1)
                        markA = i;
                    else if (diffCount == 2)
                    {
                        markB = i;
                    }
                    if (diffCount == 3)
                        return false;
                }
            }
            if (diffCount == 2 && arr_A[markB] == arr_B[markA] && arr_A[markA] == arr_B[markB] || (A == B && mark_C >= 1))

                return true;


            return false;
        }


        /// <summary>
        /// string可以直接下标访问，基础知识不扎实
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public bool BuddyStrings_B(string A, string B)
        {

           
            int length_A = A.Length;
           
            int length_B = B.Length;
            int markA = -1, markB = -1, mark_C = 0, diffCount = 0;
            if (length_A != length_B)
                return false;

            List<char> charList = new List<char>();

            for (var i = 0; i < length_A; i++)
            {
                if (charList.Contains(A[i]))
                {
                    mark_C++;
                }
                else
                {
                    charList.Add(A[i]);
                }


                if (A[i] != B[i])
                {
                    diffCount++;
                    if (diffCount == 1)
                        markA = i;
                    else if (diffCount == 2)
                    {
                        markB = i;
                    }
                    if (diffCount == 3)
                        return false;
                }
            }
            if (diffCount == 2 && A[markB] == B[markA] && A[markA] == B[markB] || (A == B && mark_C >= 1))

                return true;


            return false;
        }
    }
}
