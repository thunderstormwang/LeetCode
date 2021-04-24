using System;

namespace LeetCode
{
    public class Solution67
    {
        public string AddBinary(string a, string b)
        {
            // 較短字串補0, 補到2個字串一樣長
            // 用迴圈從最小位數開始計算, 若有進位則進到下一位
            // 迴圈結束若還有進位, 再往左補1

            string result = string.Empty;
            int numberToNextPlace = 0;

            if (a.Length < b.Length)
            {
                a = a.PadLeft(b.Length, '0');
            }
            else
            {
                b = b.PadLeft(a.Length, '0');
            }

            for (int i = a.Length - 1; i >= 0; i--)
            {
                int temp = Int32.Parse(a[i].ToString()) + Int32.Parse(b[i].ToString());
                temp += numberToNextPlace;
                result = result.PadLeft(result.Length + 1, (temp % 2).ToString()[0]);
                numberToNextPlace = (temp - temp % 2) / 2;
            }

            if (numberToNextPlace > 0)
            {
                result = result.PadLeft(result.Length + 1, '1');
            }

            return result;
        }
    }
}