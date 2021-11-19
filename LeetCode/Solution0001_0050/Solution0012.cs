using System.Text;

namespace LeetCode.Solution0000_0050
{
    public class Solution0012
    {
        public string IntToRoman(int num)
        {
            var sBuilder = new StringBuilder();
            while (num > 0)
            {
                var temp = GetRoman(num);
                num -= temp.Minus;
                sBuilder.Append(temp.Result);
            }

            return sBuilder.ToString();
        }

        private (string Result, int Minus) GetRoman(int input)
        {
            if (input >= 1000)
            {
                return ("M", 1000);
            }
            else if (input >= 900)
            {
                return ("CM", 900);
            }
            else if (input >= 500)
            {
                return ("D", 500);
            }
            else if (input >= 400)
            {
                return ("CD", 400);
            }
            else if (input >= 100)
            {
                return ("C", 100);
            }
            else if (input >= 90)
            {
                return ("XC", 90);
            }
            else if (input >= 50)
            {
                return ("L", 50);
            }
            else if (input >= 40)
            {
                return ("XL", 40);
            }
            else if (input >= 10)
            {
                return ("X", 10);
            }
            else if (input >= 9)
            {
                return ("IX", 9);
            }
            else if (input >= 5)
            {
                return ("V", 5);
            }
            else if (input >= 4)
            {
                return ("IV", 4);
            }
            else
            {
                return ("I", 1);
            }
        }
    }
}