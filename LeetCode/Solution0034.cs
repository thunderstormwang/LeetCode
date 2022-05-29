namespace LeetCode
{
    public class Solution0034
    {
        public int[] SearchRange_Recursive(int[] nums, int target)
        {
            var result = new int[2] { -1, -1 };

            Find(nums, 0, nums.Length - 1, target, result);

            return result;
        }

        public int[] SearchRange_Iterative(int[] nums, int target)
        {
            var result = new int[2] { -1, -1 };
            var start = 0;
            var end = nums.Length - 1;

            while (start <= end)
            {
                var index = start + (end - start) / 2;
                if (target < nums[index])
                {
                    end = index - 1;
                }
                else if (target > nums[index])
                {
                    start = index + 1;
                }
                else
                {
                    result[0] = FindFirst(nums, target, start, index);
                    result[1] = FindLast(nums, target, index, end);
                    break;
                }
            }

            return result;
        }

        private int FindFirst(int[] nums, int target, int start, int end)
        {
            var result = -1;
            while (start <= end)
            {
                var index = start + (end - start) / 2;
                if (target < nums[index])
                {
                    end = index - 1;
                }
                else if (target > nums[index])
                {
                    start = index + 1;
                }
                else
                {
                    result = index;
                    end = index - 1;
                }
            }

            return result;
        }

        private int FindLast(int[] nums, int target, int start, int end)
        {
            var result = -1;
            while (start <= end)
            {
                var index = start + (end - start) / 2;
                if (target < nums[index])
                {
                    end = index - 1;
                }
                else if (target > nums[index])
                {
                    start = index + 1;
                }
                else
                {
                    result = index;
                    start = index + 1;
                }
            }

            return result;
        }

        private void Find(int[] nums,
            int start,
            int end,
            int target,
            int[] result)
        {
            if (start > end)
            {
                return;
            }

            var index = start + (end - start) / 2;

            if (target < nums[index])
            {
                Find(nums,
                    start,
                    index - 1,
                    target,
                    result);
            }
            else if (target > nums[index])
            {
                Find(nums,
                    index + 1,
                    end,
                    target,
                    result);
            }
            else
            {
                result[0] = result[0] == -1 ? index : result[0];
                result[1] = result[1] == -1 ? index : result[1];

                result[0] = result[0] < index ? result[0] : index;
                result[1] = result[1] > index ? result[1] : index;

                Find(nums,
                    start,
                    index - 1,
                    target,
                    result);

                Find(nums,
                    index + 1,
                    end,
                    target,
                    result);
            }
        }
    }
}