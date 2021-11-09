using System;

namespace LeetCode.Solution0051_0100
{
    public class Solution0052
    {
        public int TotalNQueens(int n)
        {
            return FindNQueens(n,
                0,
                new int [n]);
        }
        
        private int FindNQueens(int n,
            int index,
            int[] columns)
        {
            if (index == n)
            {
                return 1;
            }

            var result = 0;

            for (var i = 0; i < n; i++)
            {
                columns[index] = i;
                if (!IsValid(columns,
                    index))
                {
                    continue;
                }

                result += FindNQueens(n,
                    index + 1,
                    columns);
            }

            return result;
        }
        
        private bool IsValid(int[] curr,
            int index)
        {
            for (var i = 0; i < index; i++)
            {
                // 不能在同一個 column, 也不能在對角線
                if (curr[i] == curr[index] ||
                    Math.Abs(index - i) == Math.Abs(curr[index] - curr[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}