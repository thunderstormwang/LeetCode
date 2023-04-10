namespace LeetCode.Solution0301_0500
{
    public class Solution0349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var set = new HashSet<int>();

            foreach (var item in nums1)
            {
                set.Add(item);
            }

            set.IntersectWith(nums2);

            return set.ToArray();
        }
        
        // 由於題目數字的範圍太大, 有上千個, 不像小寫英文只有 26 個
        // 用 array 來做會浪費許多空間, 所以用 set 來做
        
        // Time: O(N+M), N: nums1 的長度, M: nums2 的長度
        // Space: O(N)
    }
}