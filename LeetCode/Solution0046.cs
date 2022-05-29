using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0046
    {
        public IList<IList<int>> Permute_Iterative(int[] nums)
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
                        temp.Insert(index, nums[i]);
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

            FindPermute(result, 0, nums);

            return result;
        }

        private void FindPermute(IList<IList<int>> result, int index, int[] nums)
        {
            if (index == nums.Length)
            {
                result.Add(new List<int>(nums));
                return;
            }

            for (var i = index; i < nums.Length; i++)
            {
                (nums[i], nums[index]) = (nums[index], nums[i]);

                FindPermute(result,
                    index + 1,
                    nums);

                (nums[i], nums[index]) = (nums[index], nums[i]);
            }
        }
    }
}