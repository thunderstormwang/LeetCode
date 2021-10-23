﻿using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0054Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void SpiralOrderTest(int[][] input,
            int[] expected)
        {
            var solution = new Solution0054();
            var actual = solution.SpiralOrder(input);

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 },
                },
                new int[]
                {
                    1, 2, 3, 6, 9, 8, 7, 4, 5
                }
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 1, 2, 3, 4 },
                    new int[] { 5, 6, 7, 8 },
                    new int[] { 9, 10, 11, 12 }
                },
                new int[]
                {
                    1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7
                }
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 1, 2 },
                    new int[] { 3, 4 },
                    new int[] { 5, 6 },
                    new int[] { 7, 8 },
                },
                new int[]
                {
                    1, 2, 4, 6, 8, 7, 5, 3
                }
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 1 },
                    new int[] { 2 },
                },
                new int[]
                {
                    1,2
                }
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 1 }
                },
                new int[]
                {
                    1
                }
            }
        };
    }
}