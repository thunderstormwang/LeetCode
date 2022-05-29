using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999
{
    [TestFixture]
    public class Solution0559Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MaxDepth_DFS_TopDownTest(int?[] array, int expected)
        {
            var root = Utility.Build_N_ary_Tree(array);

            var solution = new Solution0559();
            var actual = solution.MaxDepth_DFS_TopDown(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MaxDepth_DFS_BottomUpTest(int?[] array, int expected)
        {
            var root = Utility.Build_N_ary_Tree(array);

            var solution = new Solution0559();
            var actual = solution.MaxDepth_DFS_BottomUp(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MaxDepth_BSFTest(int?[] array, int expected)
        {
            var root = Utility.Build_N_ary_Tree(array);

            var solution = new Solution0559();
            var actual = solution.MaxDepth_BFS(root);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, null, 3, 2, 4, null, 5, 6 },
                3
            },
            new object[]
            {
                new int?[]
                {
                    1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13,
                    null, null, 14
                },
                5
            }
        };
    }
}