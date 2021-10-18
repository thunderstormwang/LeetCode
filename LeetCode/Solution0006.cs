using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LeetCode
{
    public class Solution0006
    {
        public string Convert_V1(string s,
            int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var cycle = 2 * numRows - 2;
            var result = string.Empty;
            var firstLine = string.Empty;
            var middleLine = string.Empty;
            var latLine = string.Empty;

            if (numRows == 2)
            {
                for (int i = 0; i < s.Length; i += cycle)
                {
                    firstLine += s[i];
                }

                for (int i = numRows - 1; i < s.Length; i += cycle)
                {
                    latLine += s[i];
                }

                result = firstLine + latLine;
                return result;
            }

            var middleIndexArr = new int [numRows - 2, 2];

            for (var i = 0; i < numRows - 2; i++)
            {
                middleIndexArr[i,
                    0] = i - 1 < 0
                    ? 1
                    : middleIndexArr[i - 1,
                        0] + 1;
            }

            for (var i = numRows - 2 - 1; i >= 0; i--)
            {
                middleIndexArr[i,
                    1] = i + 1 >= numRows - 2
                    ? numRows + 1 - 1
                    : middleIndexArr[i + 1,
                        1] + 1;
            }

            for (int i = 0; i < s.Length; i += cycle)
            {
                firstLine += s[i];
            }

            for (int i = numRows - 1; i < s.Length; i += cycle)
            {
                latLine += s[i];
            }

            for (int i = 0; i < numRows - 2; i++)
            {
                var temp = 0;
                while (temp + middleIndexArr[i,
                    0] < s.Length)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        middleLine += middleIndexArr[i,
                            j] + temp >= s.Length
                            ? string.Empty
                            : s[middleIndexArr[i,
                                j] + temp].ToString();
                    }

                    temp += cycle;
                }
            }

            result = firstLine + middleLine + latLine;
            return result;
        }

        public string Convert(string s,
            int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var cycle = 2 * numRows - 2;
            var result = new StringBuilder();
            var indexArr = new int [numRows][];

            // initialize first line
            indexArr[0] = new int[1];
            indexArr[0][0] = 0;

            // initialize last line
            indexArr[numRows - 1] = new int[1];
            indexArr[numRows - 1][0] = numRows - 1;

            for (int i = 1; i <= numRows - 2; i++)
            {
                indexArr[i] = new int[2];
                indexArr[i][0] = indexArr[i - 1][0] + 1;
                indexArr[i][1] = (2 * (numRows-1)) - indexArr[i][0];
            }

            for (var i = 0; i < numRows; i++)
            {
                var temp = 0;
                while (temp + indexArr[i][0] < s.Length)
                {
                    for (var j = 0; j < indexArr[i].Length; j++)
                    {
                        result.Append(indexArr[i][j] + temp >= s.Length
                            ? string.Empty
                            : s[indexArr[i][j] + temp].ToString());
                    }

                    temp += cycle;
                }
            }

            return result.ToString();
        }
    }
}