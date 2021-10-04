using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution048Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void RotateTest(int[][] matrix,
            int[][] expected)
        {
            var solution048 = new Solution048();
            solution048.Rotate(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i].Should().Equal(expected[i]);
            }
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[][] { new int[] { 1 } },
                new int[][] { new int[] { 1 } }
            },
            new object[]
            {
                new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } },
                new int[][] { new int[] { 3, 1 }, new int[] { 4, 2 } },
            },
            new object[]
            {
                new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } },
                new int[][] { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 } },
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 5, 1, 9, 11 }, new int[] { 2, 4, 8, 10 }, new int[] { 13, 3, 6, 7 },
                    new int[] { 15, 14, 12, 16 }
                },
                new int[][]
                {
                    new int[] { 15, 13, 2, 5 }, new int[] { 14, 3, 4, 1 }, new int[] { 12, 6, 8, 9 },
                    new int[] { 16, 7, 10, 11 }
                },
            }
        };
    }
}