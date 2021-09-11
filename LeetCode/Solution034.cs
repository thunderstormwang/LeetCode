namespace LeetCode
{
    public class Solution034
    {
        public int[] SearchRange(int[] nums,
            int target)
        {
            var result = new int[2] { -1, -1 };

            Find(nums,
                0,
                nums.Length - 1,
                target,
                result);

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

                return;
            }
        }
    }
}