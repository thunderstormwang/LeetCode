﻿using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0053Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxSubArray_Ver1Test(int[] array, int expected)
    {
        var solution = new Solution0053();

        var actual = solution.MaxSubArray_Ver1(array);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void MaxSubArray_Ver2Test(int[] array, int expected)
    {
        var solution = new Solution0053();

        var actual = solution.MaxSubArray_Ver2(array);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 },
            6
        },
        new object[]
        {
            new int[] { 1 },
            1
        },
        new object[]
        {
            new int[] { 5, 4, -1, 7, 8 },
            23
        }
    };
}