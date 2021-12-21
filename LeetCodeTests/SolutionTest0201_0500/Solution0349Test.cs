using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500
{
    [TestFixture]
    public class Solution0349Test
    {
        [TestCase(new int[] { 1, 2, 2, 1 },
            new int[] { 2, 2 },
            new int[] { 2 })]
        [TestCase(new int[] { 4, 9, 5 },
            new int[] { 9, 4, 9, 8, 4 },
            new int[] { 4, 9 })]
        [TestCase(new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { })]
        public void Intersection(int[] nums1,
            int[] nums2,
            int[] expected)
        {
            var solution = new Solution0349();
            var actual = solution.Intersection(nums1,
                nums2);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}