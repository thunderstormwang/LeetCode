namespace LeetCode.Solution0001_0050;

public class Solution0048
{
    public void Rotate_Ver1(int[][] matrix)
    {
        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = i; j < matrix[i].Length; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }

        for (var i = 0; i < matrix.Length; i++)
        {
            var left = 0;
            var right = matrix[i].Length - 1;

            while (left < right)
            {
                (matrix[i][left], matrix[i][right]) = (matrix[i][right], matrix[i][left]);

                left++;
                right--;
            }
        }
    }

    public void Rotate_Ver2(int[][] matrix)
    {
        var n = matrix.Length;
        for (var i = 0; i < n / 2; i++)
        {
            for (var j = 0; j < n / 2 + n % 2; j++)
            {
                var temp = matrix[i][j];
                matrix[i][j] = matrix[n - 1 - j][i];
                matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j];
                matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i];
                matrix[j][n - 1 - i] = temp;
            }
        }
    }
}