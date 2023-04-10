﻿using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
public class Solution0525Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ChangeVer1_Test(int[] nums, int expected)
    {
        var solution = new Solution0525();
        var actual = solution.FindMaxLength(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 0, 1 },
            2
        },
        new object[]
        {
            new int[] { 0, 1, 0 },
            2
        }
    };
}