using System.Text;

namespace LeetCode.Solution0000_0050
{
    public class Solution0006
    {
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

            for (var i = 1; i <= numRows - 2; i++)
            {
                indexArr[i] = new int[2];
                indexArr[i][0] = i;
                indexArr[i][1] = cycle - i;
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
        
        // Time: O(n)
        // Space: O(n)
    }
}