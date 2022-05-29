namespace LeetCode
{
    public class Solution0219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var indexDict = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (!indexDict.ContainsKey(nums[i]))
                {
                    indexDict.Add(nums[i], i);
                    continue;
                }

                var preIndex = indexDict[nums[i]];
                if (Math.Abs(i - preIndex) <= k)
                {
                    return true;
                }

                indexDict[nums[i]] = i;
            }

            return false;
        }
    }
}