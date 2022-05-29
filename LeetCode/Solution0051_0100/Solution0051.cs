using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solution0051_0100
{
    public class Solution0051
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<int>> columns = new List<IList<int>>();
            FindNQueens(n, 0, new int [n], columns);

            IList<IList<string>> result = new List<IList<string>>();
            foreach (var item in columns)
            {
                var temp = new List<string>();
                foreach (var element in item)
                {
                    var str = new StringBuilder(new String('.', n))
                    {
                        [element] = 'Q'
                    };
                    temp.Add(str.ToString());
                }

                result.Add(temp);
            }

            return result;
        }

        private void FindNQueens(int n, int index, int[] columns, IList<IList<int>> result)
        {
            if (index == n)
            {
                result.Add(columns.ToArray());
                return;
            }

            for (var i = 0; i < n; i++)
            {
                columns[index] = i;
                if (!IsValid(columns,
                        index))
                {
                    continue;
                }

                FindNQueens(n,
                    index + 1,
                    columns,
                    result);
            }
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

        // Time: O(N^2)
        // Space: O(N)
    }
}