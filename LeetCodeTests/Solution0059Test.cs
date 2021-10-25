using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0059Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void GenerateMatrix(int n, int [][] expected)
        {
            var solution = new Solution0059();
            var actual = solution.GenerateMatrix(n);

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                1,
                new int[][]
                {
                    new int[] { 1 }
                }
            },
            new object[]
            {
                2,
                new int[][]
                {
                    new int[] { 1, 2 },
                    new int[] { 4, 3 },
                }
            },
            new object[]
            {
                3,
                new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 8, 9, 4 },
                    new int[] { 7, 6, 5 }
                }
            },
            new object[]
            {
                4,
                new int[][]
                {
                    new int[] { 1, 2, 3, 4 },
                    new int[] { 12, 13, 14, 5 },
                    new int[] { 11, 16, 15, 6 },
                    new int[] { 10, 9, 8, 7 },
                }
            }
        };
    }
}