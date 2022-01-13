using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0112Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void HasPathSum_RecursiveTest(int?[] array,
            int pathSum,
            bool expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0112();
            var actual = solution.HasPathSum_Recursive(root,
                pathSum);

            actual.Should().Be(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void HasPathSum_IterativeTest(int?[] array,
            int pathSum,
            bool expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0112();
            var actual = solution.HasPathSum_Iterative(root,
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
            },
            new object[]
            {
                new int?[] { 1, 2, 3 },
                5,
                false
            },
            new object[]
            {
                new int?[] { },
                0,
                false
            },
            new object[]
            {
                new int?[] { 1, 2 },
                1,
                false
            }
        };
    }
}