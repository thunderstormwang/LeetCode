using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0111Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MinDepth_DFS_BottomUpTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0111();
            var actual = solution.MinDepth_DFS_BottomUp(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MinDepth_DFS_TopDownTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0111();
            var actual = solution.MinDepth_DFS_TopDown(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MinDepth_BFSTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0111();
            var actual = solution.MinDepth_BFS(root);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                2
            },
            new object[]
            {
                new int?[]
                {
                    2, null, 3, null, null, null, 4, null, null, null, null, null, null, null, 5, null, null, null,
                    null, null, null, null, null, null, null, null, null, null, null, null, 6
                },
                5
            }
        };
    }
}