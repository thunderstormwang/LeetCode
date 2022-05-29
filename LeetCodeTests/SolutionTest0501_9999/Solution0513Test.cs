using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999
{
    [TestFixture]
    public class Solution0513Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void FindBottomLeftValue_DFS_RecursiveTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0513();
            var actual = solution.FindBottomLeftValue_DFS_Recursive(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void FindBottomLeftValue_DFS_IterativeTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0513();
            var actual = solution.FindBottomLeftValue_DFS_Iterative(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void FindBottomLeftValue_BFSTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0513();
            var actual = solution.FindBottomLeftValue_BFS(root);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 2, 1, 3 },
                1
            },
            new object[]
            {
                new int?[] { 1, 2, 3, 4, null, 5, 6, null, null, null, null, 7 },
                7
            }
        };
    }
}