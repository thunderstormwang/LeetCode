using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999
{
    [TestFixture]
    public class Solution0589Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void Preorder_RecursiveTest(int?[] array,
            int[] expected)
        {
            var root = Utility.Build_N_ary_Tree(array);

            var solution = new Solution0589();
            var actual = solution.Preorder_Recursive(root);

            actual.Should().Equal(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Preorder_IterativeTest(int?[] array,
            int[] expected)
        {
            var root = Utility.Build_N_ary_Tree(array);

            var solution = new Solution0589();
            var actual = solution.Preorder_Iterative(root);

            actual.Should().Equal(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, null, 3, 2, 4, null, 5, 6 },
                new int[] { 1, 3, 5, 6, 2, 4 }
            },
            new object[]
            {
                new int?[]
                {
                    1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13,
                    null, null, 14
                },
                new int[] { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 }
            }
        };
    }
}