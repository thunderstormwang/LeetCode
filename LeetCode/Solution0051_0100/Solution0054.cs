namespace LeetCode.Solution0051_0100;

public class Solution0054
{
    public IList<int> SpiralOrder_Ver1(int[][] matrix)
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

    public IList<int> SpiralOrder_Ver2(int[][] matrix)
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
                row += directArray[direction][0];
                ;
                column += directArray[direction][1];
            }
        }
        else if (rowLength >= 1 && columnLength == 1)
        {
            var direction = 1;
            for (var count = 0; count < rowLength; count++)
            {
                result.Add(matrix[row][column]);
                row += directArray[direction][0];
                ;
                column += directArray[direction][1];
            }
        }

        return result;
    }

    public IList<int> SpiralOrder_Ver3(int[][] matrix)
    {
        var direction = new List<int[]>()
        {
            new int[] { 0, 1 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { -1, 0 },
        };
        var length = new int [2] { matrix[0].Length, matrix.Length - 1 };
        var result = new List<int>() { };
        var initial = new int[] { 0, -1 };
        var count = 0;

        while (result.Count < matrix.Length * matrix[0].Length)
        {
            var len = length[count % 2];
            var dir = direction[count % 4];

            for (var i = 0; i < len; i++)
            {
                initial[0] += dir[0];
                initial[1] += dir[1];
                result.Add(matrix[initial[0]][initial[1]]);
            }

            length[count % 2]--;
            count++;
        }

        return result;
    }
}