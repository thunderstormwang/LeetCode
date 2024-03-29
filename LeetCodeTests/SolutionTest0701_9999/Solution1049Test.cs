﻿using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution1049Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LastStoneWeightII_Ver1Test(int[] stones, int expected)
    {
        var solution = new Solution1049();
        var actual = solution.LastStoneWeightII_Ver1(stones);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void LastStoneWeightII_Ver2Test(int[] stones, int expected)
    {
        var solution = new Solution1049();
        var actual = solution.LastStoneWeightII_Ver2(stones);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[]
            {
                2, 7, 4, 1, 8, 1
            },
            1
        },
        new object[]
        {
            new int[]
            {
                31, 26, 33, 21, 40
            },
            5
        }
    };
}