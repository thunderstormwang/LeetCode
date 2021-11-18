using FluentAssertions;
using LeetCode.Solution0201_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_9999
{
    [TestFixture]
    public class Solution0704Test
    {
        [TestCase(new int[] { -1, 0, 3, 5, 9, 12 },
            9,
            4)]
        [TestCase(new int[] { -1, 0, 3, 5, 9, 12 },
            2,
            -1)]
        [TestCase(new int[] { 5 },
            5,
            0)]
        [TestCase(new int[] { 5 },
            -5,
            -1)]
        public void Search_Recursive(int[] nums,
            int target,
            int expected)
        {
            var solution = new Solution0704();
            var actual = solution.Search_Recursive(nums,
                target);

            actual.Should().Be(expected);
        }
        
        [TestCase(new int[] { -1, 0, 3, 5, 9, 12 },
            9,
            4)]
        [TestCase(new int[] { -1, 0, 3, 5, 9, 12 },
            2,
            -1)]
        [TestCase(new int[] { 5 },
            5,
            0)]
        [TestCase(new int[] { 5 },
            -5,
            -1)]
        public void Search_NonRecursive(int[] nums,
            int target,
            int expected)
        {
            var solution = new Solution0704();
            var actual = solution.Search_NonRecursive(nums,
                target);

            actual.Should().Be(expected);
        }
    }
}