using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500
{
    [TestFixture]
    public class Solution0429Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void LevelOrder(int?[] array, IList<IList<int>> expected)
        {
            var root = Utility.Build_N_ary_Tree(array);

            var solution = new Solution0429();
            var actual = solution.LevelOrder(root);

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { },
                new int[][] { }
            },
            new object[]
            {
                new int?[] { 5 },
                new int[][]
                {
                    new int[] { 5 }
                }
            },
            new object[]
            {
                new int?[]
                {
                    1, null, 3, 2, 4, null, 5, 6
                },
                
                new int[][]
                {
                    new int[] { 1 },
                    new int[] { 3, 2, 4 },
                    new int[] { 5, 6 }
                }
            },
            new object[]
            {
                new int?[]
                {
                    1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13,
                    null, null, 14
                },
                new int[][]
                {
                    new int[] { 1 },
                    new int[] { 2, 3, 4, 5 },
                    new int[] { 6, 7, 8, 9, 10 },
                    new int[] { 11, 12, 13 },
                    new int[] { 14 }
                }
            }
        };
    }
}