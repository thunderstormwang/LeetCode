using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150
{
    [TestFixture]
    [Category("SolutionTest0101_0150")]
    public class Solution0113Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void PathSum_RecursiveTest(int?[] array, int targetSum, IList<IList<int>> expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0113();
            var actual = solution.PathSum_Recursive(root, targetSum);

            actual.Should().BeEquivalentTo(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void PathSum_IterativeTest(int?[] array, int targetSum, IList<IList<int>> expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0113();
            var actual = solution.PathSum_Iterative(root, targetSum);

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, null, 5, 1 },
                22,
                new int[][]
                {
                    new int[] { 5, 4, 11, 2 },
                    new int[] { 5, 8, 4, 5 }
                }
            },
            new object[]
            {
                new int?[] { 1, 2, 3 },
                5,
                new int[][] { }
            },
            new object[]
            {
                new int?[] { },
                0,
                new int[][] { }
            },
            new object[]
            {
                new int?[] { 1, 2 },
                1,
                new int[][] { }
            }
        };
    }
}