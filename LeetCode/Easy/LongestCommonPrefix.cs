using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode { 
    public class LongestCommonPrefix
    {
        #region 水平检索 

        //选择出两个字符串，通过比对获取其最长前缀

        public string LongestCommonPrefix_A(string[] strs)
        {
            if (strs.Length == 2 && strs[0] == strs[1] || strs.Length == 1)
                return strs[0];
            if (strs.Length == 0)
                return "";

            List<string> commomPrefixList=new List<string>();
            for (var i = 0; i < strs.Length - 1; i += 2)
            {
                var tmp = LongestCommonPrefix_TwoStr(strs[i], strs[i + 1]);
                if (tmp == "")
                    return "";
                else
                    commomPrefixList.Add(tmp);
            }
            if (strs.Length % 2 != 0)
                commomPrefixList.Add(strs[strs.Length - 1]);

           return  LongestCommonPrefix_A(commomPrefixList.ToArray());
        }

        public string LongestCommonPrefix_TwoStr(string str1, string str2)
        {
            

            string commonPrefix = "";
            //将str1处理成较短的字符，逐个字符进行比较
            if (str2.Length < str1.Length)
            {
                var tmp = str1;
                str1 = str2;
                str2 = tmp;
            }
            for (var i = 0; i < str1.Length; i++)
            {
                if (str1[i] == str2[i])
                {
                    commonPrefix += str1[i].ToString();
                }
                else
                    break;
            }
            return commonPrefix;
        }


        #endregion


        #region  垂直检索

        //将第一个字符，分别与其他字符串比较是否是公共字符，依次比较其他字符
        public String longestCommonPrefix_B(String[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                        return strs[0].Substring(0, i);
                }
            }
            return strs[0];
        }
        #endregion


        #region  二分查找

        //首先获取最对字符串的长度
        //二分认为，最短字符串的一半为公共前缀
        //若满足，则前缀长度+1，最低位+1，不满足高位-1
        public String longestCommonPrefix_C(String[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            int minLen = Int32.MaxValue ;
            foreach (String str in strs)
                minLen = Math.Min(minLen, str.Length);
            int low = 1;
            int high = minLen;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (isCommonPrefix(strs, middle))
                    low = middle + 1;
                else
                    high = middle - 1;
            }
            return strs[0].Substring(0, (low + high) / 2);
        }

        private bool isCommonPrefix(String[] strs, int len)
        {
            String str1 = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1))
                    return false;
            return true;
        }

        #endregion
    }
}
