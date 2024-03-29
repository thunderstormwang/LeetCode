﻿using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    [Category("SolutionTest0001_0050")]
    public class Solution0011Test
    {
        [TestCase(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [TestCase(new int[] { 1, 1 }, 1)]
        [TestCase(new int[] { 4, 3, 2, 1, 4 }, 16)]
        [TestCase(new int[] { 1, 2, 1 }, 2)]
        public void MaxAreaTest(int[] input, int expected)
        {
            var solution = new Solution0011();

            var actual = solution.MaxArea(input);

            actual.Should().Be(expected);
        }
    }
}