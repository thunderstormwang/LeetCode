using System.Collections.Generic;

namespace LeetCode
{
    public class Solution046
    {
        public IList<IList<int>> Permute_NonRecursive(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>() { new List<int>() { nums[0] } };

            for (var i = 1; i < nums.Length; i++)
            {
                IList<IList<int>> stepResult = new List<IList<int>>();
                foreach (var item in result)
                {
                    for (var index = 0; index <= item.Count; index++)
                    {
                        var temp = new List<int>();
                        temp.AddRange(item);
                        temp.Insert(index,
                            nums[i]);
                        stepResult.Add(temp);
                    }
                }

                result = stepResult;
            }

            return result;
        }

        public IList<IList<int>> Permute_Recursive(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>() { };
            var unused = new List<int>(nums);

            FindPermute(result,
                new List<int>(),
                unused);

            return result;
        }

        private void FindPermute(IList<IList<int>> result,
            List<int> curr,
            List<int> unused)
        {
            if (unused.Count == 0)
            {
                result.Add(new List<int>(curr));
            }

            for (var i = 0; i < unused.Count; i++)
            {
                curr.Add(unused[i]);
                unused.RemoveAt(i);
                FindPermute(result,
                    curr,
                    unused);
                unused.Insert(i,
                    curr[curr.Count - 1]);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}