using FluentAssertions;
using LeetCode;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100
{
    [TestFixture]
    public class Solution0094Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void InorderTraversal_Recursive(int?[] array,
            int[] expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0094();
            var actual = solution.InorderTraversal_Recursive(root);

            actual.Should().Equal(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void InorderTraversal_Iterative(int?[] array,
            int[] expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0094();
            var actual = solution.InorderTraversal_Iterative(root);

            actual.Should().Equal(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, null, 2, null, null, 3 },
                new int[] { 1, 3, 2 },
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
                new int[] { 1, 2 },
            }
        };
    }
}