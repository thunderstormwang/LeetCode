namespace LeetCode.Solution0051_0100;

public class Solution0073
{
    public void SetZeroes(int[][] matrix)
    {
        var firstRowZero = false;
        var firstColumnZero = false;

        for (var j = 0; j < matrix[0].Length; j++)
        {
            if (matrix[0][j] == 0)
            {
                firstRowZero = true;
            }
        }

        for (var i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][0] == 0)
            {
                firstColumnZero = true;
            }
        }

        for (var i = 1; i < matrix.Length; i++)
        {
            for (var j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
            }
        }

        for (var i = 1; i < matrix.Length; i++)
        {
            for (var j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        if (firstRowZero)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                matrix[0][j] = 0;
            }
        }

        if (firstColumnZero)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}