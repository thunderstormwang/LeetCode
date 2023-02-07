﻿using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
public class Solution0714Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxProfitTest(int[] prices, int fee, int expected)
    {
        var solution = new Solution0714();
        var actual = solution.MaxProfit(prices, fee);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 3, 2, 8, 4, 9 },
            2,
            8
        },
        new object[]
        {
            new int[] { 1, 3, 7, 5, 10, 3 },
            3,
            6
        },
        new object[]
        {
            new int[] { 1, 3, 8, 5, 10, 3 },
            3,
            6
        },
        new object[]
        {
            new int[] { 1, 8, 7, 20 },
            2,
            17
        }
    };
}