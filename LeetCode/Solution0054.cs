using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0054
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();
            var rowLength = matrix.Length;
            var columnLength = matrix[0].Length;
            var i = 0;
            var j = 0;
            var count = 0;

            while (0 < rowLength - 1 && 0 < columnLength - 1)
            {
                count = 0;
                while (count < columnLength - 1)
                {
                    result.Add(matrix[i][j]);
                    j++;
                    count++;
                }

                count = 0;
                while (count < rowLength - 1)
                {
                    result.Add(matrix[i][j]);
                    i++;
                    count++;
                }

                count = 0;
                while (count < columnLength - 1)
                {
                    result.Add(matrix[i][j]);
                    j--;
                    count++;
                }

                count = 0;
                while (count < rowLength - 1)
                {
                    result.Add(matrix[i][j]);
                    i--;
                    count++;
                }

                rowLength -= 2;
                columnLength -= 2;
                i ++;
                j ++;
            }

            if (rowLength == 1 && columnLength >= 1)
            {
                count = 0;
                while (count < columnLength)
                {
                    result.Add(matrix[i][j]);
                    j++;
                    count++;
                }
            }
            else if (rowLength >= 1 && columnLength == 1)
            {
                count = 0;
                while (count < rowLength)
                {
                    result.Add(matrix[i][j]);
                    i++;
                    count++;
                }
            }

            return result;
        }
    }
}