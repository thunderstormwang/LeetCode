using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solution0001_0050
{
    public class Solution0040
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            var result = new List<IList<int>>();
            FindCombinationSum(candidates,
                target,
                0,
                new List<int>(),
                result);
            return result;
        }

        private void FindCombinationSum(int[] candidates,
            int target,
            int startIndex,
            IList<int> curr,
            IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(curr.ToArray());
                return;
            }

            for (var i = startIndex; i < candidates.Length; i++)
            {
                if (target < candidates[i])
                {
                    continue;
                }

                if (i > startIndex && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                curr.Add(candidates[i]);
                FindCombinationSum(candidates,
                    target - candidates[i],
                    i + 1,
                    curr,
                    result);
                curr.Remove(candidates[i]);
            }
        }

        // 因為陣列每個元素不是唯一, 在每次遞迴中要注意不能挑到相同的元素, 不然會計算出相同組合
        // ex: 2, 2, 2, 5, target = 7

        // Time: O(2^N)
        // Space: O(N)
    }
}