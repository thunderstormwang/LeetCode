namespace LeetCode.Solution0001_0050;

public class Solution0004
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums2.Length < nums1.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        var n1 = nums1.Length;
        var n2 = nums2.Length;
        var k = (n1 + n2 + 1) / 2;

        var left = 0;
        var right = n1;
        var m1 = 0;
        var m2 = 0;

        while(left < right)
        {
            m1 = left + (right - left) / 2;
            m2 = k - m1;
            if(nums1[m1] < nums2[m2 - 1])
            {
                left = m1 + 1;
            }
            else
            {
                right = m1;
            }
        }

        m1 = left;
        m2 = k - m1;

        var center1 = Math.Max(m1 <= 0 ? int.MinValue : nums1[m1 - 1],
            m2 <= 0 ? int.MinValue : nums2[m2 - 1]);

        if((n1 + n2) % 2 == 1)
        {
            return center1;
        }

        var center2 = Math.Min(m1 >= n1 ? int.MaxValue : nums1[m1], 
            m2 >= n2 ? int.MaxValue : nums2[m2]);
        
        return (center1 + center2) / 2d;
    }
}