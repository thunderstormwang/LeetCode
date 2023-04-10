using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500
{
    [TestFixture]
    public class Solution0454Test
    {
        [TestCase(new int[] { 1, 2 }, new int[] { -2, -1 }, new int[] { -1, 2 }, new int[] { 0, 2 }, 2)]
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, 0)]
        [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { 0 }, new int[] { 0 }, 1)]
        [TestCase(new int[] { 1 }, new int[] { -1 }, new int[] { 0 }, new int[] { 1 }, 0)]
        public void FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4, int expected)
        {
            var solution = new Solution0454();
            var actual = solution.FourSumCount(nums1, nums2, nums3, nums4);

            actual.Should().Be(expected);
        }
    }
}