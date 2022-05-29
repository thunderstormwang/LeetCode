using System;
using System.Linq;

namespace LeetCode
{
    public class Solution0043
    {
        public string Multiply(string num1, string num2)
        {
            var result = string.Empty;

            num1 = string.Join(string.Empty, num1.Reverse());
            num2 = string.Join(string.Empty, num2.Reverse());
            var array = new int[num1.Length + num2.Length];

            for (var i = 0; i < num1.Length; i++)
            {
                var temp1 = Convert.ToInt32(num1.Substring(i, 1));
                for (var j = 0; j < num2.Length; j++)
                {
                    var temp2 = Convert.ToInt32(num2.Substring(j, 1));
                    array[i + j] += temp1 * temp2;
                    array[i + j + 1] += array[i + j] / 10;
                    array[i + j] %= 10;
                }
            }

            result = string.Join(string.Empty, array.Reverse());

            while (result.StartsWith("0"))
            {
                result = result.Substring(1);
            }

            return string.IsNullOrEmpty(result) ? "0" : result;
        }
    }
}