using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode
{
    public class Solution220
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums,
            int k,
            int t)
        {
            var bucketDict = new Dictionary<long, long>();
            var width = (long)t + 1;

            for (var i = 0; i < nums.Length; i++)
            {
                var bucketId = GetBucketId(nums[i],
                    width);

                var targetBucketId = bucketId;
                if (bucketDict.ContainsKey(targetBucketId))
                {
                    return true;
                }

                targetBucketId = bucketId - 1;
                if (bucketDict.ContainsKey(targetBucketId) && Math.Abs(nums[i] - bucketDict[targetBucketId]) < width)
                {
                    return true;
                }

                targetBucketId = bucketId + 1;
                if (bucketDict.ContainsKey(targetBucketId) && Math.Abs(nums[i] - bucketDict[targetBucketId]) < width)
                {
                    return true;
                }

                bucketDict.Add(bucketId,
                    nums[i]);

                if (i >= k)
                {
                    var tempId = GetBucketId(nums[i - k],
                        width);
                    bucketDict.Remove(tempId);
                }
            }

            return false;
        }

        private long GetBucketId(long input,
            long width)
        {
            return input >= 0 ? input / width : input / width - 1;
        }
    }
}