﻿using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100
{
    [TestFixture]
    public class Solution0070Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void ClimbStairsTest(int n, int expected)
        {
            var solution = new Solution0070();

            var actual = solution.ClimbStairs(n);

            actual.Should().Be(expected);
        }
        
        private static readonly object[] TestCases =
        {
            new object[]
            {
                1, 1
            },
            new object[]
            {
                2, 2
            },
            new object[]
            {
                3, 3
            },
            new object[]
            {
                4, 5
            },
            new object[]
            {
                5, 8
            }
        };
    }
}