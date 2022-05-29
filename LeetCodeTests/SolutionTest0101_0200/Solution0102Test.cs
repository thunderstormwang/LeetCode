using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0102Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void LevelOrder(int?[] array, IList<IList<int>> expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0102();
            var actual = solution.LevelOrder(root);

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                new int[][]
                {
                    new int[] { 3 },
                    new int[] { 9, 20 },
                    new int[] { 15, 7 }
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