namespace LeetCode
{
    public class Solution0048
    {
        public void Rotate(int[][] matrix)
        {
            Transpose(matrix);

            ReverseRow(matrix);
        }

        private void ReverseRow(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                var startIndex = 0;
                var endIndex = row.Length - 1;
                while (startIndex < endIndex)
                {
                    (row[startIndex], row[endIndex]) = (row[endIndex], row[startIndex]);

                    startIndex++;
                    endIndex--;
                }
            }
        }

        private void Transpose(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = i; j < matrix[i].Length; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }
        }
    }
}