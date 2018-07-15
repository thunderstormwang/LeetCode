namespace LeetCode
{
    public class Solution88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                InsertNumber(nums1, m, nums2[i]);
                m++;
            }
        }

        private void InsertNumber(int[] nums1, int m, int target)
        {
            if (m == 0)
            {
                nums1[0] = target;
                return;
            }

            bool isInsert = false;
            for (int i = m - 1; i >= 0; i--)
            {
                if (nums1[i] > target)
                {
                    nums1[i + 1] = nums1[i];
                }
                else
                {
                    nums1[i + 1] = target;
                    isInsert = true;
                    break;
                }
            }

            if (!isInsert)
            {
                nums1[0] = target;
            }
        }
    }
}