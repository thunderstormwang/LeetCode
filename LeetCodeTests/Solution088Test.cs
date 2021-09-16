using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution088Test
    {
        [TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        public void MergeTest(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            var solution88 = new Solution88();

            solution88.Merge(nums1, m, nums2, n);

            nums1.Should().Equal(expected);
        }
    }
}