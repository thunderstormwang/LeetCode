using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0056Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MergeTest(int[][] input,
            int[][] expected)
        {
            var solution = new Solution0056();

            var actual = solution.Merge(input);

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[][]
                {
                    new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 }
                },
                new int[][]
                {
                    new int[] { 1, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 }
                },
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 1, 4 }, new int[] { 4, 5 }
                },
                new int[][]
                {
                    new int[] { 1, 5 }
                },
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 1, 3 }, new int[] { 4, 5 }
                },
                new int[][]
                {
                    new int[] { 1, 3 }, new int[] { 4, 5 }
                },
            }
        };
    }
}