using System.Collections.Generic;

namespace LeetCode
{
    public class Solution217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();
            foreach (var item in nums)
            {
                if (!hashSet.Add(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}