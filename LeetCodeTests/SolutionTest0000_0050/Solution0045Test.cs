using FluentAssertions;
using LeetCode.Solution0000_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0000_0050
{
    [TestFixture]
    public class Solution0045Test
    {
        [TestCase(new int[] { 2, 3, 1, 1, 4 },
            2)]
        [TestCase(new int[] { 2, 3, 1, 0, 4 },
            2)]
        [TestCase(new int[] { 2, 1 },
            1)]
        [TestCase(new int[] { 2 },
            0)]
        public void Jump_DynamicProgrammingTest(int[] nums,
            int expected)
        {
            var solution = new Solution0045();

            var actual = solution.Jump_DynamicProgramming(nums);

            actual.Should().Be(expected);
        }

        [TestCase(new int[] { 2, 3, 1, 1, 4 },
            2)]
        [TestCase(new int[] { 2, 3, 1, 0, 4 },
            2)]
        [TestCase(new int[] { 2, 1 },
            1)]
        [TestCase(new int[] { 2 },
            0)]
        public void Jump_GreedyTest(int[] nums,
            int expected)
        {
            var solution = new Solution0045();

            var actual = solution.Jump_Greedy(nums);

            actual.Should().Be(expected);
        }
    }
}