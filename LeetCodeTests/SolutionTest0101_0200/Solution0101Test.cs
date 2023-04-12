using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    [Category("SolutionTest0101_0200")]
    public class Solution0101Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void IsSymmetric_DFS_RecursiveTest(int? [] array, bool expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0101();
            var actual = solution.IsSymmetric_DFS_Recursive(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void IsSymmetric_DFS_Iterative_Test(int? [] array, bool expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0101();
            var actual = solution.IsSymmetric_DFS_Iterative(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void IsSymmetric_BFS_Test(int? [] array, bool expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0101();
            var actual = solution.IsSymmetric_BFS(root);

            actual.Should().Be(expected);
        }
        
        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 2, 2, 3, 4, 4, 3 },
                true
            },
            new object[]
            {
                new int?[] { 1, 2, 2, null, 3, null, 3 },
                false
            }
        };
    }
}