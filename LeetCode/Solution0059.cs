using System;

namespace LeetCode
{
    public class Solution0059
    {
        public int[][] GenerateMatrix(int n)
        {
            var result = new int [n][];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = new int[n];
            }

            var counter = 1;
            var row = 0;
            var column = 0;
            var sideLength = n;

            while (counter < n * n)
            {
                var length = sideLength - 1;
                for (var i = 0; i < length; i++)
                {
                    result[row][column++] = counter++;
                }

                for (var i = 0; i < length; i++)
                {
                    result[row++][column] = counter++;
                }

                for (var i = 0; i < length; i++)
                {
                    result[row][column--] = counter++;
                }

                for (var i = 0; i < length; i++)
                {
                    result[row--][column] = counter++;
                }

                sideLength -= 2;
                row++;
                column++;
            }

            if (sideLength == 1)
            {
                result[row][column] = counter;
            }

            return result;
        }
    }
}