using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100
{
    [TestFixture]
    public class Solution0055Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void CanJump(int[] nums, bool expected)
        {
            var solution = new Solution0055();
            var actual = solution.CanJump(nums);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { 2, 3, 1, 1, 4 },
                true
            },
            new object[]
            {
                new int[] { 3, 2, 1, 0, 4 },
                false
            },
            new object[]
            {
                new int[] { 0, 0, 4 },
                false
            },
            new object[]
            {
                new int[] { 0 },
                true
            }
        };
    }
}