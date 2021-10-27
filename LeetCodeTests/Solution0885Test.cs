using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0885Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void SpiralMatrixIIITest(int rows,
            int cols,
            int rStart,
            int cStart,
            int[][] expected)
        {
            var solution = new Solution0885();
            var actual = solution.SpiralMatrixIII(rows,
                cols,
                rStart,
                cStart);

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                1,
                4,
                0,
                0,
                new int[][]
                {
                    new int[] { 0, 0 },
                    new int[] { 0, 1 },
                    new int[] { 0, 2 },
                    new int[] { 0, 3 },
                }
            },
            new object[]
            {
                3,
                3,
                1,
                1,
                new int[][]
                {
                    new int[] { 1, 1 },
                    new int[] { 1, 2 },
                    new int[] { 2, 2 },
                    new int[] { 2, 1 },
                    new int[] { 2, 0 },
                    new int[] { 1, 0 },
                    new int[] { 0, 0 },
                    new int[] { 0, 1 },
                    new int[] { 0, 2 }
                }
            },
            new object[]
            {
                5,
                6,
                1,
                4,
                new int[][]
                {
                    new int[] { 1, 4 },
                    new int[] { 1, 5 },
                    new int[] { 2, 5 },
                    new int[] { 2, 4 },
                    new int[] { 2, 3 },
                    new int[] { 1, 3 },
                    new int[] { 0, 3 },
                    new int[] { 0, 4 },
                    new int[] { 0, 5 },
                    new int[] { 3, 5 },
                    new int[] { 3, 4 },
                    new int[] { 3, 3 },
                    new int[] { 3, 2 },
                    new int[] { 2, 2 },
                    new int[] { 1, 2 },
                    new int[] { 0, 2 },
                    new int[] { 4, 5 },
                    new int[] { 4, 4 },
                    new int[] { 4, 3 },
                    new int[] { 4, 2 },
                    new int[] { 4, 1 },
                    new int[] { 3, 1 },
                    new int[] { 2, 1 },
                    new int[] { 1, 1 },
                    new int[] { 0, 1 },
                    new int[] { 4, 0 },
                    new int[] { 3, 0 },
                    new int[] { 2, 0 },
                    new int[] { 1, 0 },
                    new int[] { 0, 0 }
                }
            },
        };
    }
}