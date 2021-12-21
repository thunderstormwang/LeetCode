using FluentAssertions;
using LeetCode;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500
{
    [TestFixture]
    public class Solution0226Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void InvertTree_DFS_RecursiveTest(int?[] inputArray, int?[] expectedArray)
        {
            var root = Utility.BuildTree( inputArray, 0);
            var expected = Utility.BuildTree( expectedArray, 0);

            var solution = new Solution0226();
            var actual = solution.InvertTree_DFS_Recursive(root);

            Utility.CheckBinaryTree(actual,
                expected).Should().BeTrue();
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void InvertTree_DFS_IterativeTest(int?[] inputArray, int?[] expectedArray)
        {
            var root = Utility.BuildTree( inputArray, 0);
            var expected = Utility.BuildTree( expectedArray, 0);

            var solution = new Solution0226();
            var actual = solution.InvertTree_DFS_Iterative(root);

            Utility.CheckBinaryTree(actual,
                expected).Should().BeTrue();
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void InvertTree_BFSTest(int?[] inputArray, int?[] expectedArray)
        {
            var root = Utility.BuildTree( inputArray, 0);
            var expected = Utility.BuildTree( expectedArray, 0);

            var solution = new Solution0226();
            var actual = solution.InvertTree_BFS(root);

            Utility.CheckBinaryTree(actual,
                expected).Should().BeTrue();
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 4, 2, 7, 1, 3, 6, 9 },
                new int?[] { 4, 7, 2, 9, 6, 3, 1 }
            },
            new object[]
            {
                new int?[] { 2, 1, 3 },
                new int?[] { 2, 3, 1 }
            },
            new object[]
            {
                new int?[] { },
                new int?[] { }
            }
        };
    }
}