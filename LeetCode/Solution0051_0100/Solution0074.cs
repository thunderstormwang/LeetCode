namespace LeetCode.Solution0051_0100;

public class Solution0074
{
    public bool SearchMatrix_Ver1(int[][] matrix, int target) {
        var left = 0;
        var right = matrix.Length - 1;

        while(right - left > 1)
        {
            var middle = (left + right) / 2;
            if(matrix[middle][0] == target)
            {
                return true;
            }

            if(matrix[middle][0] <= target)
            {
                left = middle;
            }
            else
            {
                right = middle - 1;
            }
        }

        var row = matrix[right][0] <= target ? right : left;
        left = 0;
        right = matrix[0].Length - 1;

        while(left <= right)
        {
            var middle = (left + right) / 2;
            if(matrix[row][middle] == target)
            {
                return true;
            }

            if(matrix[row][middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return false;
    }
    
    public bool SearchMatrix_Ver2(int[][] matrix, int target) {
        var left = 0;
        var right = matrix.Length * matrix[0].Length - 1;

        while(left <= right)
        {
            var middle = (left + right) / 2;
            var row = middle / matrix[0].Length;
            var column = middle % matrix[0].Length;

            if(matrix[row][column] == target)
            {
                return true;
            }

            if(matrix[row][column] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return false;        
    }
}