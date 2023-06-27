using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700
{
    [TestFixture]
    [Category("SolutionTest0501_0700")]
    public class Solution0590Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void Postorder_Recursive(int?[] array, int[] expected)
        {
            var root = Utility.Build_N_ary_Tree(array);

            var solution = new Solution0590();
            var actual = solution.Postorder_Recursive(root);

            actual.Should().Equal(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Postorder_Iterative(int?[] array, int[] expected)
        {
            var root = Utility.Build_N_ary_Tree(array);

            var solution = new Solution0590();
            var actual = solution.Postorder_Iterative(root);

            actual.Should().Equal(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, null, 3, 2, 4, null, 5, 6 },
                new int[] { 5, 6, 3, 2, 4, 1 }
            },
            new object[]
            {
                new int?[]
                {
                    1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13,
                    null, null, 14
                },
                new int[] { 2, 6, 14, 11, 7, 3, 12, 8, 4, 13, 9, 10, 5, 1 }
            }
        };
    }
}