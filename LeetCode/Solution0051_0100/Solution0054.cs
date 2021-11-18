using System.Collections.Generic;

namespace LeetCode.Solution0051_0100
{
    public class Solution0054
    {
        public IList<int> SpiralOrder_Version1(int[][] matrix)
        {
            var result = new List<int>();
            var rowLength = matrix.Length;
            var columnLength = matrix[0].Length;
            var row = 0;
            var column = 0;

            while (0 < rowLength - 1 && 0 < columnLength - 1)
            {
                for (var count = 0; count < columnLength - 1; count++)
                {
                    result.Add(matrix[row][column]);
                    column++;
                }
                
                for (var count = 0; count < rowLength - 1; count++)
                {
                    result.Add(matrix[row][column]);
                    row++;
                }

                for (var count = 0; count < columnLength - 1; count++)
                {
                    result.Add(matrix[row][column]);
                    column--;
                }

                for (var count = 0; count < rowLength - 1; count++)
                {
                    result.Add(matrix[row][column]);
                    row--;
                }

                rowLength -= 2;
                columnLength -= 2;
                row++;
                column++;
            }

            if (rowLength == 1 && columnLength >= 1)
            {
                for (var count = 0; count < columnLength; count++)
                {
                    result.Add(matrix[row][column]);
                    column++;
                }
            }
            else if (rowLength >= 1 && columnLength == 1)
            {
                for (var count = 0; count < rowLength; count++)
                {
                    result.Add(matrix[row][column]);
                    row++;
                }
            }

            return result;
        }

        public IList<int> SpiralOrder_Version2(int[][] matrix)
        {
            var result = new List<int>();
            var rowLength = matrix.Length;
            var columnLength = matrix[0].Length;
            var row = 0;
            var column = 0;
            var directArray = new int[4][]
            {
                new int[2] { 0, 1 },
                new int[2] { 1, 0 },
                new int[2] { 0, -1 },
                new int[2] { -1, 0 }
            };

            while (0 < rowLength - 1 && 0 < columnLength - 1)
            {
                var direction = 0;
                var sideLength = new int[] { columnLength - 1, rowLength - 1, columnLength - 1, rowLength - 1 };

                for (var i = 0; i < sideLength.Length; i++)
                {
                    for (var count = 0; count < sideLength[i]; count++)
                    {
                        result.Add(matrix[row][column]);
                        row += directArray[direction][0];
                        column += directArray[direction][1];
                    }
                    direction = (direction + 1) % 4;
                }

                rowLength -= 2;
                columnLength -= 2;
                row++;
                column++;
            }

            if (rowLength == 1 && columnLength >= 1)
            {
                var direction = 0;
                for (var count = 0; count < columnLength; count++)
                {
                    result.Add(matrix[row][column]);
                    row += directArray[direction][0];;
                    column += directArray[direction][1];
                }
            }
            else if (rowLength >= 1 && columnLength == 1)
            {
                var direction = 1;
                for (var count = 0; count < rowLength; count++)
                {
                    result.Add(matrix[row][column]);
                    row += directArray[direction][0];;
                    column += directArray[direction][1];
                }
            }

            return result;
        }
        
        // 這題沒用到演算法, 就是考寫程式的功力
        // 矩形有四個邊, 在每一個方向走 row-1 或是 column-1 步, 就不用考慮是否要包含邊界的問題, 走完一圈就往內圈走
        // 最後要考慮只剩 1條 row 或是只剩 1條 column 的 special case
    }
}