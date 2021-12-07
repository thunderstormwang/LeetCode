using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0107Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void LevelOrderBottom_BFSTest(int?[] array,
            IList<IList<int>> expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0107();
            var actual = solution.LevelOrderBottom_BFS(root);

            actual.Should().BeEquivalentTo(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void LevelOrderBottom_DFSTest(int?[] array,
            IList<IList<int>> expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0107();
            var actual = solution.LevelOrderBottom_DFS(root);

            actual.Should().BeEquivalentTo(expected);
        }
        
        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                new int[][]
                {
                    new int[] { 15, 7 },
                    new int[] { 9, 20 },
                    new int[] { 3 },
                }
            },
            new object[]
            {
                new int?[] { 1 },
                new int[][]
                {
                    new int[] { 1 }
                }
            },
            new object[]
            {
                new int?[] { },
                new int[][] { }
            }
        };
    }
}