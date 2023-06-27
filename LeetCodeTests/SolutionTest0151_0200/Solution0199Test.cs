using FluentAssertions;
using LeetCode.Solution0151_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0151_0200
{
    [TestFixture]
    [Category("SolutionTest0151_0200")]
    public class Solution0199Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void RightSideView_DFS(int?[] array, int[] expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0199();
            var actual = solution.RightSideView_DFS(root);

            actual.Should().Equal(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void RightSideView_BFS(int?[] array, int[] expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0199();
            var actual = solution.RightSideView_BFS(root);

            actual.Should().Equal(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 2, 3, null, 5, null, 4 },
                new int[] { 1, 3, 4 }
            },
            new object[]
            {
                new int?[] { 1, null, 3 },
                new int[] { 1, 3 }
            },
            new object[]
            {
                new int?[] { 1, 3, null },
                new int[] { 1, 3 }
            },

            new object[]
            {
                new int?[] { },
                new int[] { }
            },
        };
    }
}