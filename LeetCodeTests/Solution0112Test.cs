using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0112Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void HasPathSumTest(int? [] array,
            int pathSum,
            bool expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0112();
            var actual = solution.HasPathSum(root,
                pathSum);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 },
                22,
                true
            }
        };
    }
}