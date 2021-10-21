using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;

namespace LeetCode
{
    public class Solution0039
    {
        public IList<IList<int>> CombinationSum(int[] candidates,
            int target)
        {
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

                curr.Add(candidates[i]);
                FindCombinationSum(candidates,
                    target - candidates[i],
                    i,
                    curr,
                    result);
                curr.Remove(candidates[i]);
            }
        }
    }
}