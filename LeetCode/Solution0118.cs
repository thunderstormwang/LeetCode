﻿namespace LeetCode
{
    public class Solution0118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();

            if (numRows == 0)
            {
                return result;
            }

            result.Add(new List<int>() { 1 });

            if (numRows == 1)
            {
                return result;
            }

            result.Add(new List<int>() { 1, 1 });

            if (numRows == 2)
            {
                return result;
            }

            for (int i = 2; i <= numRows - 1; i++)
            {
                result.Add(new List<int>() { 1 });

                for (int j = 1; j <= i - 1; j++)
                {
                    result[i].Add(result[i - 1][j - 1] + result[i - 1][j]);
                }

                result[i].Add(1);
            }

            return result;
        }
    }
}