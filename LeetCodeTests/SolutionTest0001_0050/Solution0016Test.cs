﻿using FluentAssertions;
using LeetCode;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0016Test
{
    [TestCase(new int[] { -1, 2, 1, -4 }, 1, 2)]
    [TestCase(new int[] { 0, 0, 0 }, 1, 0)]
    [TestCase(new int[] { 0, 2, 1, -3 }, 1, 0)]
    public void ThreeSumClosestTest(int[] input, int target, int expected)
    {
        var solution = new Solution0016();

        var actual = solution.ThreeSumClosest(input, target);

        actual.Should().Be(expected);
    }
}