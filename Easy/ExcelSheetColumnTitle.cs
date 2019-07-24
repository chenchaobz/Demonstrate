using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ExcelSheetColumnTitle
    {


        public string ConvertToTitle_A(int n)
        {
            var output = new char[8];   // This should be big enough for the billionth column.

            // Write each digit in the column name from the least to the most significant digit.
            int i = 0;  // Number of characters in the column name
            do
            {
                n = n - 1;
                output[i++] = GetChar(n % 26);
                n = n / 26;
            }
            while (n > 0);

            // So far, the column name has been build backwards,
            // so we need to reverse the order to build up the string correctly.
            Array.Reverse(output, 0, i);
            return new string(output, 0, i);
        }

        private char GetChar(int n)
        {
           char _charA = 'A';
           int baseNum = Convert.ToInt32(_charA);
           return (char)(baseNum+n);
        }
    }
}
