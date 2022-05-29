namespace LeetCode
{
    public class Solution0189
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;

            if (k == 0)
            {
                return;
            }

            var loop = FindGreatestCommonFactor(nums.Length, k);
            
            for (var i = 0; i < loop; i++)
            {
                var newIndex = (i + k) % nums.Length;

                while (newIndex != i)
                {
                    Swap(nums, i, newIndex);
                    newIndex = (newIndex + k) % nums.Length;
                }
            }
        }

        private int FindGreatestCommonFactor(int a, int b)
        {
            if (a < b)
            {
                (a, b) = (b, a);
            }

            while (a % b != 0)
            {
                var temp = a % b;
                a = b;
                b = temp;
            }

            return b;
        }

        private void Swap(int[] nums, int i, int j)
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }
    }
}