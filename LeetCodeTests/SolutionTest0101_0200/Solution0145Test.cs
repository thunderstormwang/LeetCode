using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0145Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void PostorderTraversal_Recursive(int?[] array,
            int[] expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0145();
            var actual = solution.PostorderTraversal_Recursive(root);

            actual.Should().Equal(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void PostorderTraversal_Iterative(int?[] array,
            int[] expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0145();
            var actual = solution.PostorderTraversal_Iterative(root);

            actual.Should().Equal(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, null, 2, null, null, 3 },
                new int[] { 3, 2, 1 },
            },
            new object[]
            {
                new int?[] { },
                new int[] { },
            },
            new object[]
            {
                new int?[] { 1 },
                new int[] { 1 },
            },
            new object[]
            {
                new int?[] { 1, 2 },
                new int[] { 2, 1 },
            },
            new object[]
            {
                new int?[] { 1, null, 2 },
                new int[] { 2, 1 },
            }
        };
    }
}