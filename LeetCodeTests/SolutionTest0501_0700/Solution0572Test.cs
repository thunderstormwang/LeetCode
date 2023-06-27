using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700
{
    [TestFixture]
    [Category("SolutionTest0501_0700")]
    public class Solution0572Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void IsSubtree_DFS_RecursiveTest(int?[] rootArray, int?[] subRootArray, bool expected)
        {
            var root = Utility.BuildTree( rootArray, 0);
            var subRoot = Utility.BuildTree( subRootArray, 0);

            var solution = new Solution0572();
            var actual = solution.IsSubtree_DFS_Recursive(root, subRoot);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void IsSubtree_DFS_IterativeTest(int?[] rootArray, int?[] subRootArray, bool expected)
        {
            var root = Utility.BuildTree( rootArray, 0);
            var subRoot = Utility.BuildTree( subRootArray, 0);

            var solution = new Solution0572();
            var actual = solution.IsSubtree_DFS_Iterative(root, subRoot);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void IsSubtree_BFSTest(int?[] rootArray, int?[] subRootArray, bool expected)
        {
            var root = Utility.BuildTree( rootArray, 0);
            var subRoot = Utility.BuildTree( subRootArray, 0);

            var solution = new Solution0572();
            var actual = solution.IsSubtree_BFS(root, subRoot);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 4, 5, 1, 2 },
                new int?[] { 4, 1, 2 },
                true
            },
            new object[]
            {
                new int?[] { 3, 4, 5, 1, 2, null, null, null, null, 0 },
                new int?[] { 4, 1, 2 },
                false
            }
        };
    }
}