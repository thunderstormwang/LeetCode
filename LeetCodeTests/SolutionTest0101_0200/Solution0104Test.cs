using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
       [Category("SolutionTest0101_0200")]
    public class Solution0104Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MaxDepth_DFS_BottomUpTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0104();
            var actual = solution.MaxDepth_DFS_BottomUp(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MaxDepth_DFS_TopDownTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0104();
            var actual = solution.MaxDepth_DFS_TopDown(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MaxDepth_BFS_Test(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0104();
            var actual = solution.MaxDepth_BFS(root);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                3
            },
            new object[]
            {
                new int?[] { 1, null, 2 },
                2
            },
            new object[]
            {
                new int?[] { },
                0
            },
        };
    }
}