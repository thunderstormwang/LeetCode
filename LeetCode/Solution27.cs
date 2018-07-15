namespace LeetCode
{
    public class Solution27
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[index] != nums[i])
                {
                    nums[index + 1] = nums[i];
                    index++;
                }
            }

            return index + 1;
        }

        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int lastIndex = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != val && lastIndex == 0)
                {
                    lastIndex = i;
                }

                if (nums[i] == val && lastIndex == 0)
                {
                    continue;
                }
                else if (nums[i] == val && lastIndex != 0)
                {
                    int temp = nums[lastIndex];
                    nums[lastIndex] = nums[i];
                    nums[i] = temp;
                    lastIndex--;
                }
            }

            if (lastIndex == 0 && nums[lastIndex] == val)
            {
                return 0;
            }

            return lastIndex + 1;
        }
    }
}